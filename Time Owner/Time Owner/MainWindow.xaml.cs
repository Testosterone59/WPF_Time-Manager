using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Media;
using System.Collections.ObjectModel;
using Hardcodet.Wpf.TaskbarNotification;

namespace Time_Owner
{

    public partial class MainWindow : Window
    {

        private DataWeek selectedDataWeek;
        private DataDay selectedDataDay;

        private TimeSpan timerTime, wholeTimer;

        /// <summary>
        /// To determine the current mode (Work, Rest)
        /// </summary>
        private TimerStage timerStage;

        private ApplicationMode applicationMode = ApplicationMode.Day;

        private ModesOfWork modeOfWork = ModesOfWork.Pomodoro;

        private bool taskStarted = false;

        /// <summary>
        /// For check user changed data
        /// </summary>
        public static bool dataChanged = false;
        private int receivedTomato;


        public static readonly DependencyProperty IsVisibleProfileProperty = DependencyProperty.RegisterAttached(
           "IsVisibleProfile",
           typeof(bool),
           typeof(MainWindow));

        /// <summary>
        /// Value of visibility the grid profile
        /// </summary>
        public bool IsVisibleProfile
        {
            get { return (bool)GetValue(IsVisibleProfileProperty); }
            set { SetValue(IsVisibleProfileProperty, value); }
        }

        /// <summary>
        /// Array of the current selected days
        /// </summary>
        private ObservableCollection<Day> days = new ObservableCollection<Day>();

        private Task selectedTask { get { return _selectedTask; } set
            {
                if (taskStarted)
                    StopTimer();

                _selectedTask = value;
            } }
        private Task _selectedTask;

        private DispatcherTimer dispatcherTimer;
        private DispatcherTimer timerAutoSave;

        private SoundPlayer soundPlayer;

        private TaskbarIcon taskbar;

        private WindowProgressBar progressBar;
        private WindowRest windowRest;

        public static MainWindow _singleton;


        private enum ModesOfWork
        {
            Pomodoro = 0,
            Timer = 1
        }

        public MainWindow()
        {
            InitializeComponent();
            try
            {
                InitializeProgram();
                InitializeTimers();
                InitializeTaskbar();
            }
            catch(Exception e) { Error(e); Close(); }
        }
        void InitializeProgram()
        {
            _singleton = this;

            contentDays.ItemsSource = days;

            GlobalSettings.InitializePathes();

            Load(DateTime.Now, GlobalSettings.pathData); 
            LoadSounds();
            FileManager.LoadSettings();
            FileManager.LoadProfile();

            RecalculateSizes(); 
        }

        private void LoadSounds()
        {
            soundPlayer = new SoundPlayer(Time_Owner.Properties.Resources.Signal);
            soundPlayer.Load();
        }

        private void InitializeTimers()
        {
            UpdateButtonsTimer();

            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(TimerTick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

            timerAutoSave = new DispatcherTimer();
            timerAutoSave.Tick += new EventHandler(AutoSave);
            timerAutoSave.Interval = new TimeSpan(0, 30, 0);
            timerAutoSave.Start();
        }

        private void InitializeTaskbar()
        {
            taskbar = new TaskbarIcon();
            taskbar.Icon = Time_Owner.Properties.Resources.icon;

            taskbar.TrayMouseDoubleClick +=
                delegate (object sender, RoutedEventArgs args)
                {
                    if (IsVisible)
                        Hide();
                    else
                    {
                        Show();
                        Activate();
                        WindowState = WindowState.Normal;
                    }
                };

            taskbar.ContextMenu = new ContextMenu();

            MenuItem miAbout = new MenuItem { Header = "About" };
            miAbout.Click +=
                delegate (object sender, RoutedEventArgs args)
                {
                    OpenInfo(null);
                };

            MenuItem miClose = new MenuItem { Header = "Exit" };
            miClose.Click +=
                delegate (object sender, RoutedEventArgs args)
                {
                    Exit();
                };

            taskbar.ContextMenu.Items.Add(miAbout);
            taskbar.ContextMenu.Items.Add(miClose);
        }

        /// <summary>
        /// Minimize to the task bar (Button)
        /// </summary>
        protected void MinimizeToTaskBarClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// Minimize to the tray (Button)
        /// </summary>
        protected void MinimizeToTrayClick(object sender, RoutedEventArgs e)
        {
            Hide();
        }

        /// <summary>
        /// Exit application
        /// </summary>
        private void Exit()
        {
            /// Save changed data
            Save();
            
            taskbar.Dispose();

            /// If true then show the window about of program
            if (GlobalSettings.dataSettings.EnableWindowInfo)
                OpenInfo(() => Application.Current.Shutdown());
            else
                Application.Current.Shutdown(); 
        }

        /// <summary>
        /// Open the window of settings (Button)
        /// </summary>
        private void SettingsClick(object sender, RoutedEventArgs e)
        {
            Settings window = new Settings();
            window.Owner = this;
            if (window.ShowDialog() == true) { }
        }

        private void StatisticsClick(object sender, RoutedEventArgs e)
        {
            StatisticsWindow window = StatisticsWindow.GetInstance();
            window.Owner = this;
            window.Show();
            window.Activate();
        }

        /// <summary>
        /// For drag the window
        /// </summary>
        private void moveRectangle_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void ShowNotifyMessage(string message, int second)
        {
            soundPlayer.PlaySync();

            TaskbarMessage element = new TaskbarMessage() { Text = message, actionClick = () => taskbar.CloseBalloon() };
            taskbar.ShowCustomBalloon(element, System.Windows.Controls.Primitives.PopupAnimation.Slide, second * 1000); 
        }

        private void Load(DateTime dateTime, string path)
        {
            if (taskStarted)
                StopTimer();

            days.Clear();
            Day.dragDropDatas.Clear();

            /// Create a tasks from the loaded data
            selectedDataWeek = FileManager.LoadWeek(dateTime, path);

            switch (applicationMode)
            {
                case ApplicationMode.Day:
                    /// Create the day data
                    selectedDataDay = selectedDataWeek.GetDay(dateTime);

                    CreateDayGUI(selectedDataDay);

                    break;
                case ApplicationMode.Week:
                    /// Create the week data

                    foreach (var d in selectedDataWeek.days)
                        CreateDayGUI(d.Value);

                    break;
            }

            /// Update the data of interface
            labelInfoDay.Content = $"The selected date is {dateTime.Day}.{dateTime.Month}.{dateTime.Year}";
            taskDescription.Document.Blocks.Clear();
            selectedTask = null;

            UpdateTimerInfo();
            UpdateTotalTime();
            UpdateButtonsTimer();

            dataChanged = false;
        }

        private void CreateDayGUI(DataDay dataDay)
        {
            Day day = new Day(dataDay, v => BtnAddTask(v));
            if (dataDay.tasks.Count > 0)
            {
                List<Task> tasks = new List<Task>();

                foreach (var t in dataDay.tasks)
                    tasks.Add(TaskElement(t));

                day.AddTasks(tasks.ToArray());
            }
            days.Add(day);
        }

        private void AutoSave(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (!dataChanged)
                return;

            FileManager.SaveWeek(selectedDataWeek, GlobalSettings.pathData);
            FileManager.SaveProfile();

            dataChanged = false;
        }

 

        /// <summary>
        /// Function of add a new task
        /// </summary>
        /// <param name="day">Target day</param>
        private void BtnAddTask(Day day)
        {
            TaskWindow window = new TaskWindow();
            window.Owner = this;
            DataTask newTask = new DataTask("New Task", string.Empty, 0, 0);

            /// To open the window of add new task
            if (window.ShowDialog(newTask, () => AddTask(newTask, day)) == true) { }
        }

        /// <summary>
        /// A delegate function
        /// </summary>
        private void AddTask(DataTask dataTask, Day day)
        {
            day.DataDay.tasks.Add(dataTask);

            day.AddTask(TaskElement(dataTask));

            dataChanged = true;
        }

        /// <summary>
        /// Create a task interface element
        /// </summary>
        /// <returns>Created element</returns>
        private Task TaskElement(DataTask dataTask)
        {
            return new Task(dataTask, () => OnTaskToggleChecked(dataTask), (sender) => OnTaskChanged(sender));
        }

        /// <summary>
        /// Open the window of task edit (Button)
        /// </summary>
        private void BtnEditTask(object sender, RoutedEventArgs e)
        {
            if (selectedTask == null)
                return;

            OnEditTask(selectedTask);
        }

        /// <summary>
        /// Open the window of task edit
        /// </summary>
        /// <param name="task">Target task</param>
        public void OnEditTask(Task task)
        {
            TaskWindow window = new TaskWindow();
            window.Owner = this;
            if (window.ShowDialog(task.DataTask, null) == true) { }

            if (selectedTask == task)
                OnSelectTask();

            dataChanged = true;
        }

        /// <summary>
        /// Open the window of task delete (Button)
        /// </summary>
        private void BtnDeleteTask(object sender, RoutedEventArgs e)
        {
            if (selectedTask == null)
                return;

            OnDeleteTask(selectedTask);
        }

        /// <summary>
        /// Open the window of task delete
        /// </summary>
        public void OnDeleteTask(Task task)
        {
            if (task == null || taskStarted && task == selectedTask)
                return;

            /// Call the confirmation window
            if (MessageBox.Show(this, $"Do you wanna delete the task '{task.DataTask.TaskName}'", "Delete Task", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                DeleteTask(task);
        }

        private void DeleteTask(Task task)
        {
            task.Remove();
            selectedTask = null;
            ClearSelectionData();

            dataChanged = true;
        }

        /// <summary>
        /// Copy a task to custom dates (Open the window)
        /// </summary>
        public void CopyTask(Task task)
        {
            SelectDate window = new SelectDate();
            window.Owner = this;
            if (window.ShowDialog((collection) => CopyTask(task, collection)) == true) { }
        }

        /// <summary>
        /// Copy a task to custom dates
        /// </summary>
        public void CopyTask(Task task, SelectedDatesCollection dates)
        {
            if (dates == null || dates.Count == 0)
                return;

            var target = task.DataTask;

            DataTask dataTaskCopy = new DataTask(
                target.TaskName, target.Info, 0, 0);

            List<DataWeek> weeks = new List<DataWeek>();

            // Check if current week was update
            bool update = false;

            foreach (var d in dates)
            {
                // Search a date in a list of loaded weeks 
                int indexWeek = weeks.FindIndex((w) => w.HasDate(d));

                // If it's found then to add a task into a task list
                if (indexWeek >= 0)
                    weeks[indexWeek].days[d.DayOfWeek].tasks.Add(dataTaskCopy);

                // Otherwise, load a needed week and add it into a list then add a task copy
                else
                {
                    if (!weeks.Contains(selectedDataWeek) && selectedDataWeek.HasDate(d))
                    {
                        update = true;
                        dataChanged = false;

                        if (taskStarted)
                            StopTimer();

                        selectedDataWeek.days[d.DayOfWeek].tasks.Add(dataTaskCopy);
                        weeks.Add(selectedDataWeek);
                    }
                    else
                    {
                        DataWeek newWeek = FileManager.LoadWeek(d, GlobalSettings.pathData);
                        newWeek.days[d.DayOfWeek].tasks.Add(dataTaskCopy);

                        weeks.Add(newWeek);
                    }
                }
            }

            // Save changes
            foreach (var w in weeks)
                FileManager.SaveWeek(w, GlobalSettings.pathData);

            if (update)
                LoadCalendarDate(calendar);
        }

        /// <summary>
        /// Open the window about of program
        /// </summary>
        private void OpenInfo(Action actionEnd)
        {
            WindowInfo window = new WindowInfo(actionEnd);
            window.Owner = this;
            if (window.ShowDialog() == true) { }
        }

        /// <summary>
        /// Invoked if was selected the new current task
        /// </summary>
        private void OnTaskChanged(Task sender)
        {
            /// If current task was run on or current task equal a new task then return
            if (taskStarted || selectedTask == sender)
                return;

            /// Unselect an old task
            if (selectedTask != null)
                selectedTask.OnUnselect();

            selectedTask = sender;
            selectedTask.OnSelect();
            OnSelectTask();
        }

        private void OnTaskToggleChecked(DataTask task)
        {
            dataChanged = true;
            if (task != selectedTask?.DataTask)
                return;

            if (taskStarted)
                StopTimer();
            else
                UpdateButtonsTimer();
        }

        private void OnClickCalendar(object sender, RoutedEventArgs e)
        {
            if (taskStarted)
                return;
            if (calendar.Visibility == Visibility.Hidden)
               { calendar.Visibility = Visibility.Visible; dockModePanel.Visibility = Visibility.Visible; }
            else
               { calendar.Visibility = Visibility.Hidden; dockModePanel.Visibility = Visibility.Hidden; }
        }

        private void OnSelectTask()
        {
            taskDescription.Document.Blocks.Clear();
            taskDescription.AppendText(selectedTask.DataTask.Info);

            UpdateTimerInfo();
            UpdateButtonsTimer();
        }

        private void ClearSelectionData()
        {
            taskDescription.Document.Blocks.Clear();
        }

        /// <summary>
        /// It's only for the Pomodoro mode
        /// </summary>
        private void ChangeTimerStage()
        {
            switch (timerStage)
            {
                case TimerStage.Work:
                    receivedTomato++;
                    selectedTask.DataTask.Tomatoes++; 
                    // Adding exp to profile
                    Profile.data.AddExperience((int)wholeTimer.TotalMinutes);

                    UpdateTotalTime();
                    dataChanged = true;

                    bool isLongBreak = false;

                    // If hasn't passed 4 tomatoes then do a simple break, else do a long break
                    if (receivedTomato % 4 != 0)
                        wholeTimer = new TimeSpan(0, GlobalSettings.dataSettings.TimeOfBreak, 0);
                    else { wholeTimer = new TimeSpan(0, GlobalSettings.dataSettings.TimeOfLongBreak, 0);
                        isLongBreak = true; }

                    timerStage = TimerStage.Break;
                    selectedTask.DataTask.TotalTime = 
                        selectedTask.DataTask.TotalTime.Add(new TimeSpan(0, GlobalSettings.dataSettings.TimeOfWork, 0));
                    UpdateTotalTime();
                    TaskbarItemInfo.ProgressState = System.Windows.Shell.TaskbarItemProgressState.Paused;

                    Save();

                    // If the window of rest is enable than open it
                    if (GlobalSettings.dataSettings.EnableWindowBreak)
                    {
                        windowRest = new WindowRest();
                        windowRest.PathImage = !isLongBreak ? GlobalSettings.dataSettings.PathImgBreakTime :
                            GlobalSettings.dataSettings.PathImgLongBreakTime;

                        windowRest.Show();

                       if (progressBar != null)
                            progressBar.Activate(); 
                    }
                    break;
                case TimerStage.Break:
                    wholeTimer = new TimeSpan(0, GlobalSettings.dataSettings.TimeOfWork, 0);
                    timerStage = TimerStage.Work;
                    TaskbarItemInfo.ProgressState = System.Windows.Shell.TaskbarItemProgressState.Normal;

                    if (windowRest != null) { windowRest.Close(); windowRest = null; }
                    break;
            }
            timerTime = wholeTimer;
            ShowNotifyMessage(timerStage.ToCapsString(), 10);
            UpdateTimerInfo();
        }

        /// <summary>
        /// Invoking from a xaml code
        /// </summary>
        private void ChangeModeOfWork(int newIndex)
        {
            modeOfWork = (ModesOfWork)newIndex;

            if (taskStarted)
                StopTimer();
        }

        /// <summary>
        /// Invoked from DispatcherTimer each one second when timer is running
        /// </summary>
        private void TimerTick(object sender, EventArgs e)
        {
            if (!taskStarted)
                return;
            try
            {
                switch (modeOfWork)
                {
                    case ModesOfWork.Pomodoro:

                        timerTime = timerTime.Subtract(new TimeSpan(0, 0, 0, 1));
                        var totalSeconds = timerTime.TotalSeconds;

                        if (totalSeconds <= 0)
                            ChangeTimerStage();
                        else if (timerStage == TimerStage.Work && totalSeconds == 30)
                            ShowNotifyMessage("A break will begin in 30 seconds", 10);

                        textTimerTime.Text = timerTime.ToString();

                        double progress = 1;

                        if (timerTime.TotalSeconds > 0)
                            progress = wholeTimer.Subtract(timerTime).TotalSeconds / (wholeTimer.TotalSeconds);

                        if (TaskbarItemInfo != null)
                            TaskbarItemInfo.ProgressValue = progress;

                        if (progressBar != null)
                            progressBar.SetValue(progress * 100);

                        if (windowRest != null)
                            windowRest.SetTimerData(timerTime.Minutes, timerTime.Seconds);

                        break;
                    case ModesOfWork.Timer:

                        timerTime = timerTime.Add(new TimeSpan(0, 0, 1));
                        
                        if (GlobalSettings.dataSettings.TimeOfGettingTomato > 0 &&
                            timerTime.TotalMinutes == GlobalSettings.dataSettings.TimeOfGettingTomato)
                        {
                            selectedTask.DataTask.Tomatoes++;

                            // Adding a total time to a selected task
                            selectedTask.DataTask.TotalTime =
                                selectedTask.DataTask.TotalTime.Add(timerTime);

                            // Adding exp to profile
                            Profile.data.AddExperience((int)GlobalSettings.dataSettings.TimeOfGettingTomato);

                            wholeTimer = wholeTimer.Add(timerTime);
                            timerTime = new TimeSpan();

                            UpdateTotalTime();
                            dataChanged = true;
                        }

                        var totalTime = timerTime.Add(wholeTimer);

                        textTimerTime.Text = totalTime.ToString();

                        if (GlobalSettings.dataSettings.MaximumTaskTime > 0 &&
                            totalTime.TotalMinutes + selectedTask.DataTask.TotalTime.TotalMinutes
                            >= GlobalSettings.dataSettings.MaximumTaskTime)
                        {
                            StopTimer();
                            ShowNotifyMessage("Max time of whole task is up", 10);
                        }

                        break;
                }
            }
            catch(Exception exc) { Error(exc); StopTimer(); }
        }

        public static void Error(Exception e)
        {
            FileManager.SaveLog(e, GlobalSettings.pathLogs);
            _singleton.ShowNotifyMessage("An error has occurred", 10);
        }

        private void CalendarSelectedDatesChanged(object sender, EventArgs e)
        {
            var calendar = sender as Calendar;

            LoadCalendarDate(calendar);
        }

        private void LoadCalendarDate(Calendar calendar)
        {
            if (!calendar.SelectedDate.HasValue)
                calendar.SelectedDate = calendar.DisplayDate;

            DateTime date = calendar.SelectedDate.Value;
            Save();
            Load(date, GlobalSettings.pathData);
        }

        private void UpdateTimerInfo()
        {
            switch (modeOfWork)
            {
                case ModesOfWork.Pomodoro:
                    textTimerStage.Text = taskStarted ? timerStage.ToCapsString() : "OFF";
                    break;
                case ModesOfWork.Timer:
                    textTimerStage.Text = taskStarted ? "WORK" : "OFF";
                    break;
            }

            if (selectedTask != null)
                textTimerTotalTime.Text = $"Time in total {selectedTask.DataTask.TotalTime.ToString()}";
        }

        private void UpdateTotalTime()
        {
            TimeSpan timeSpan = new TimeSpan();

            foreach (var d in days)
                foreach (var t in d.tasks)
                    timeSpan = timeSpan.Add(t.DataTask.TotalTime);

            textTimerTotalTimeMode.Text = $"Total working time {timeSpan.ToString()}";
        }

        private void UpdateButtonsTimer()
        {
            if (selectedTask == null || selectedTask.DataTask.IsDone) { btnPlay.Visibility = Visibility.Hidden; btnStop.Visibility = Visibility.Hidden; return; }
            if (taskStarted) { btnPlay.Visibility = Visibility.Hidden; btnStop.Visibility = Visibility.Visible; }
            else { btnPlay.Visibility = Visibility.Visible; btnStop.Visibility = Visibility.Hidden; }
        }

        /// <summary>
        /// Launch the timer
        /// </summary>
        private void BtnPlayTimer(object sender, RoutedEventArgs e)
        {
            switch (modeOfWork)
            {
                case ModesOfWork.Pomodoro:
                    timerStage = TimerStage.Work;

                    // Set time from settings to 'wholeTimer' and 'timerTime'
                    wholeTimer = new TimeSpan(0, GlobalSettings.dataSettings.TimeOfWork, 0);
                    timerTime = wholeTimer;

                    TaskbarItemInfo.ProgressState = System.Windows.Shell.TaskbarItemProgressState.Normal;
                    TaskbarItemInfo.ProgressValue = 0;

                    progressBar = new WindowProgressBar();
                    progressBar.Show();

                    receivedTomato = 0;
                    break;
                case ModesOfWork.Timer:

                    if (GlobalSettings.dataSettings.MaximumTaskTime > 0 &&
                        selectedTask.DataTask.TotalTime.TotalMinutes >= GlobalSettings.dataSettings.MaximumTaskTime)
                    {
                        ShowNotifyMessage("Max time of whole task is up", 10);
                        return;
                    }

                    timerTime = new TimeSpan();
                    wholeTimer = new TimeSpan();
                    break;
            }
            taskStarted = true;

            UpdateTimerInfo();
            UpdateButtonsTimer();

            dispatcherTimer.Start();

        }

        private void BtnStopTimer(object sender, RoutedEventArgs e)
        {
            StopTimer();
        }

        private void StopTimer()
        {
            taskStarted = false;
            textTimerTime.Text = $"00:00:00";

            switch (modeOfWork)
            {
                case ModesOfWork.Pomodoro:
                    if (timerStage == TimerStage.Work)
                    {
                        // Get the difference between the specified time and the past time
                        TimeSpan time = new TimeSpan(0, GlobalSettings.dataSettings.TimeOfWork, 0).Subtract(timerTime);
                        selectedTask.DataTask.TotalTime = selectedTask.DataTask.TotalTime.Add(time);
                        UpdateTotalTime();
                        // Adding exp to profile
                        Profile.data.AddExperience((int)time.TotalMinutes);
                    }

                    TaskbarItemInfo.ProgressState = System.Windows.Shell.TaskbarItemProgressState.None;

                    progressBar.Close();
                    progressBar = null;
                    break;
                case ModesOfWork.Timer:
                    selectedTask.DataTask.TotalTime = selectedTask.DataTask.TotalTime.Add(timerTime);
                    UpdateTotalTime();

                    // Adding exp to profile
                    Profile.data.AddExperience((int)timerTime.TotalMinutes);
                    break;
            }

            UpdateTimerInfo();
            UpdateButtonsTimer();

            dispatcherTimer.Stop();
            dataChanged = true;
        }

        private void ComboboxModeChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ApplicationMode newMode = (ApplicationMode)comboboxMode.SelectedIndex;
                if (newMode == applicationMode) { return; }
                DateTime date = calendar.SelectedDate ?? calendar.DisplayDate;
                Save();
                applicationMode = newMode;
                Load(date, GlobalSettings.pathData);
            }
            catch(Exception ex) { FileManager.SaveLog(ex, GlobalSettings.pathLogs); }
        }

        private void WindowResize(object sender, SizeChangedEventArgs e)
        {
            RecalculateSizes();
        }

        private void OnProfileClick(object sender, RoutedEventArgs e)
        {
            IsVisibleProfile = !IsVisibleProfile;

            if (IsVisibleProfile)
            {
                Grid.SetRow(tasksPanel, 4);
                Grid.SetRow(contentDays, 5);
                Grid.SetRowSpan(contentDays, 1);
            }
            else
            {
                Grid.SetRow(tasksPanel, 2);
                Grid.SetRow(contentDays, 3);
                Grid.SetRowSpan(contentDays, 3);
            }
        }

        private void RecalculateSizes()
        {
            GlobalSettings.UpdateElementTasksValues(labelInfoDay.ActualHeight, contentDays.ActualWidth - SystemParameters.VerticalScrollBarWidth);
        }

        private void OpenContextMenuWithLeftClick(object sender, RoutedEventArgs e)
        {
            if (!(sender is Button))
                return;

            Button element = (Button)sender;
            element.ContextMenu.IsOpen = true;
        }

        private void ClickOpenInfo(object sender, RoutedEventArgs e)
        {
            OpenInfo(null);
        }

        private void ClickExit(object sender, RoutedEventArgs e)
        {
            Exit();
        }

    }
}
