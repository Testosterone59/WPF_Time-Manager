using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using System.Collections.ObjectModel;
using WPF.JoshSmith.ServiceProviders.UI;

namespace Time_Owner
{

    public partial class Day : UserControl
    {
        public static readonly DependencyProperty DataDayProperty = DependencyProperty.Register(
           "DataDay", typeof(DataDay), typeof(Day));
        public DataDay DataDay
        {
            get { return (DataDay)GetValue(DataDayProperty); }
            set { SetValue(DataDayProperty, value); }
        }

        public ObservableCollection<Task> tasks = new ObservableCollection<Task>();

        public static List<DragDropData> dragDropDatas = new List<DragDropData>();

        private ListViewDragDropManager<Task> dragMgr;

        private Action<Day> eventAddTask;

        public Day(DataDay dataDay, Action<Day> eventAddTask)
        {
            InitializeComponent();
            InitializeListViewDragDropManager();

            DataDay = dataDay;
            this.nameDay.Content = DataDay.dayOfWeek.ToString();
            this.eventAddTask = eventAddTask;
            dragDropDatas.Add(new DragDropData(this, dragMgr));
        }

        public void AddTask(Task t)
        {
            tasks.Add(t);
            t.onRemove = () => RemoveTask(t);
        }

        public void AddTasks(Task[] t)
        {
            foreach (var t2 in t)
            {
                AddTask(t2);
            }
        }

        public void RemoveTask(Task t)
        {
            DataDay.tasks?.Remove(t.DataTask);
            tasks?.Remove(t);
        }

        public void ClearTasks()
        {
            tasks.Clear();
        }

        void InitializeListViewDragDropManager()
        {
            this.contentTasks.ItemsSource = tasks;
            dragMgr = new ListViewDragDropManager<Time_Owner.Task>(this.contentTasks);
            contentTasks.DragEnter += OnListViewDragEnter;
            contentTasks.Drop += OnListViewDrop;
        }

        void OnListViewDragEnter(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.Move;
        }

        void OnListViewDrop(object sender, DragEventArgs e)
        {
            MainWindow.dataChanged = true;
            if (e.Effects == DragDropEffects.None)
                return;

            // Receive a dragged task
            Task task = e.Data.GetData(typeof(Task)) as Task;

            DragDropData dragDropDataSender = dragDropDatas.Find((d) => d.day == this);
            DragDropData dragDropDataDragger = dragDropDatas.Find((d) => d.mrg.IsDragInProgress);

            if (dragDropDataSender != dragDropDataDragger)
            {
                dragDropDataSender.day.DataDay.tasks.Add(task.DataTask);
                dragDropDataDragger.day.DataDay.tasks.Remove(task.DataTask); 

                dragDropDataDragger.day.tasks.Remove(task);
            }
            // It is necessary because need to keep the sequence while saving
            int indexTask = dragDropDataSender.day.tasks.IndexOf(task);
            int indexDataTask = dragDropDataSender.day.DataDay.tasks.IndexOf(task.DataTask);

            if (indexTask != indexDataTask)
                dragDropDataSender.day.DataDay.tasks.Swap(indexTask, indexDataTask);

        }

        private void BtnAddTask(object sender, RoutedEventArgs e)
        {
            eventAddTask.Invoke(this);
        }


    }
}
