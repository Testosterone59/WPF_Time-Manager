using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WPF.JoshSmith.ServiceProviders.UI;

namespace Time_Owner
{
    public class DataDay
    {
        public Date date;
        public DayOfWeek dayOfWeek;
        public ObservableCollection<DataTask> tasks = new ObservableCollection<DataTask>();
        public DataDay(DateTime date) { this.date = new Date(date); dayOfWeek = date.DayOfWeek; }
        public DataDay(Date date) { this.date = date; }

        /// <summary>
        /// Get all time work of all tasks
        /// </summary>
        public TimeSpan CalculateAllTime()
        {
            TimeSpan span = new TimeSpan();

            foreach (var t in tasks)
                span = span.Add(t.TotalTime);

            return span;
        }
    }

    public class DataWeek
    {
        public Dictionary<DayOfWeek, DataDay> days = new Dictionary<DayOfWeek, DataDay>();

        public bool isEmpty { get
            {
                foreach (var i in days.Values)
                    if (i.tasks.Count > 0)
                        return false;

                return true;
            } }

        public bool inRange(DateTime date)
        {
            foreach (var d in days.Values)
                if (d.date.day == date.Day && d.date.month == date.Month && d.date.year == date.Year)
                    return true;

            return false;
        }

        public DataDay GetDay(DateTime date)
        {
            foreach (var d in days.Values)
                if (d.date.day == date.Day && d.date.month == date.Month && d.date.year == date.Year)
                    return d;

            return days[DayOfWeek.Monday];
        }

        public bool HasDate(DateTime date)
        {
            if (days.Count == 0)
                return false;
            
            foreach (var d in days)
            {
                var value = d.Value;

                if (value.date.day == date.Day &&
                    value.date.month == date.Month &&
                    value.date.year == date.Year)
                    return true;
            }

            return false;
        }

        public void FillDefault(DateTime startDate)
        {
            if (days.Count > 0)
                days.Clear();

            for (int i=0; i<7; i++)
            {
                days.Add(startDate.DayOfWeek, new DataDay(startDate));
                startDate = startDate.AddDays(1);
            }
        }

        public override bool Equals(Object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType())
                return false;

            DataWeek d = (DataWeek)obj;

            DataDay thisMonday = days[DayOfWeek.Monday];
            DataDay otherMonday = d.days[DayOfWeek.Monday];

            // Compare only Monday with Monday, because it's easily, than compare all days each other
            return (thisMonday.date.day == otherMonday.date.day) &&
                (thisMonday.date.month == otherMonday.date.month) &&
                (thisMonday.date.year == otherMonday.date.year);
        }
    }

    /// <summary>
    /// This class used only for Statistics
    /// </summary>
    public class DateMonth
    {
        /// <summary>
        /// Key=Day number of month
        /// </summary>
        public Dictionary<int, DayMonth> values = new Dictionary<int, DayMonth>();

        public TimeSpan TotalTime { get; set; }

        public int month;
        public int year;

        public string Title { get { return $"({MonthCalendar.MonthNames[month - 1]} {year})"; } }

        public DateMonth(int month, int year)
        {
            this.month = month;
            this.year = year;
        }

        public void CalculateTotalTime()
        {
            TotalTime = new TimeSpan();

            foreach (var v in values.Values)
                TotalTime = TotalTime.Add(v.allTimeOfWork);
        }

        public class DayMonth
        {
            public DayOfWeek dayOfWeek;

            public TimeSpan allTimeOfWork;

            public DayMonth(DayOfWeek dayOfWeek, TimeSpan allTimeOfWork)
            {
                this.dayOfWeek = dayOfWeek;
                this.allTimeOfWork = allTimeOfWork;
            }
        }
    }

    public class DataTask : DependencyObject
    {
        public static readonly DependencyProperty TaskNameProperty = DependencyProperty.Register(
           "TaskName", typeof(string), typeof(DataTask));
        public string TaskName
        {
            get { return (string)GetValue(TaskNameProperty); }
            set { SetValue(TaskNameProperty, value); }
        }

        public static readonly DependencyProperty InfoProperty = DependencyProperty.Register(
           "Info", typeof(string), typeof(DataTask));
        public string Info
        {
            get { return (string)GetValue(InfoProperty); }
            set { SetValue(InfoProperty, value); }
        }

        public static readonly DependencyProperty TomatoesProperty = DependencyProperty.Register(
           "Tomatoes", typeof(int), typeof(DataTask));
        public int Tomatoes
        {
            get { return (int)GetValue(TomatoesProperty); }
            set { SetValue(TomatoesProperty, value); }
        }

        public static readonly DependencyProperty IsDoneProperty = DependencyProperty.Register(
           "IsDone", typeof(bool), typeof(DataTask));
        public bool IsDone
        {
            get { return (bool)GetValue(IsDoneProperty); }
            set { SetValue(IsDoneProperty, value); }
        }

        public static readonly DependencyProperty TotalTimeProperty = DependencyProperty.Register(
           "TotalTime", typeof(TimeSpan), typeof(DataTask));
        public TimeSpan TotalTime
        {
            get { return (TimeSpan)GetValue(TotalTimeProperty); }
            set { SetValue(TotalTimeProperty, value); }
        }

        public Task gui { get; set; }

        public DataTask(string name, string info, int totalSeconds, int tomatoes, bool done = false)
        { this.TaskName = name; this.Info = info; this.TotalTime = new TimeSpan(0, 0, 0, totalSeconds);
            this.Tomatoes = tomatoes; this.IsDone = done; }
    }

    public struct Date
    {
        public int day;
        public int month;
        public int year;
        public Date(DateTime date) { day = date.Day; month = date.Month; year = date.Year; }
        public override bool Equals(Object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType())
                return false;

            Date d = (Date)obj;
            return (day == d.day) && (month == d.month) && (year == d.year);
        }
    }

    public struct DateOfWeek
    {
        public DayOfWeek dayOfWeek;
        public Date date;
        public DateOfWeek(DayOfWeek dayOfWeek, Date date) { this.dayOfWeek = dayOfWeek; this.date = date; }
    }

    public class DragDropData
    {
        public Day day;
        public ListViewDragDropManager<Task> mrg;
        public DragDropData(Day day, ListViewDragDropManager<Task> mrg) { this.day = day; this.mrg = mrg; }
    }

    public class Goal
    {
        public string Name { get; set; }

        private DateTime? _dateEnd;
        public DateTime? dateEnd { get { return _dateEnd; } set { _dateEnd = value;
                remainingTime = CalculateRemainingTime(); } }

        public string remainingTime { get; set; }

        public Goal() { Name = "New Goal"; dateEnd = null; }

        private string CalculateRemainingTime()
        {
            if (!dateEnd.HasValue)
                return string.Empty;

            TimeSpan time = dateEnd.Value - DateTime.Now;

            if (time.TotalHours > 0)
                return $"{Math.Round(time.TotalDays, 1)} Days";
            else
                return "Time is up";
        }
    }
    /// <summary>
    /// Class for keep of the user data
    /// </summary>
    public static class Profile
    {
        public static Data data = new Data();

        public class Data : DependencyObject
        {

            public static readonly DependencyProperty LevelProperty = DependencyProperty.Register(
               "Level", typeof(int), typeof(Data));
            public int Level
            {
                get { return (int)GetValue(LevelProperty); }
                set { SetValue(LevelProperty, value); ExperienceToNextLevel = Level * Level * 100; }
            }

            public static readonly DependencyProperty ExperienceProperty = DependencyProperty.Register(
               "Experience", typeof(int), typeof(Data));
            public int Experience
            {
                get { return (int)GetValue(ExperienceProperty); }
                set {
                    if (value < 0)
                        value = 0;
                    SetValue(ExperienceProperty, value); }
            }

            public static readonly DependencyProperty ExperienceToNextLevelProperty = DependencyProperty.Register(
               "ExperienceToNextLevel", typeof(int), typeof(Data));
            public int ExperienceToNextLevel
            {
                get { return (int)GetValue(ExperienceToNextLevelProperty); }
                private set { SetValue(ExperienceToNextLevelProperty, value); }
            }

            public static readonly DependencyProperty GoalsProperty = DependencyProperty.Register(
               "Goals", typeof(ObservableCollection<Goal>), typeof(Data));
            public ObservableCollection<Goal> Goals
            {
                get { return (ObservableCollection<Goal>)GetValue(GoalsProperty); }
                set { SetValue(GoalsProperty, value); }
            }

            public void AddExperience(int count)
            {
                if (Experience + count >= ExperienceToNextLevel)
                {
                    int offset = (Experience + count) - ExperienceToNextLevel;
                    Level++;
                    Experience = offset;
                }
                else
                    Experience += count;
            }

            public Data()
            {
                Level = 1;
                Experience = 0;
                Goals = new ObservableCollection<Goal>() { null, null,null};
            }
        }
    }

    struct TaskGUI
    {
        public DataTask task;
        public TaskGUI(DataTask task)
        { this.task = task; }
        public void SetComplete() { task.IsDone = true; }
    }

    public enum TimerStage
    {
        Work = 0,
        Break = 1
    }

    public enum ApplicationMode
    {
        Day = 0,
        Week = 1
    }

    public static class StringExtensions
    {
        public static string[] Split(this string value, string pattern)
        {
            List<string> result = new List<string>();
            int startIndex = 0;
            int endIndex = 0;
            int patternLenght = pattern.Length;
            while (endIndex != -1)
            {
                endIndex = value.IndexOf(pattern, startIndex);
                if (endIndex == -1) { break; }
                string newValue = value.Substring(startIndex, endIndex - startIndex);
                result.Add(newValue);
                startIndex = endIndex + patternLenght;
            }
            return result.ToArray();
        }
        public static string DocumentToString(this RichTextBox rtb)
        {
            TextRange textRange = new TextRange(
                rtb.Document.ContentStart,
                rtb.Document.ContentEnd
            );
            return textRange.Text;
        }
    }

    public static class EnumExtensions
    {
        public static string ToCapsString(this TimerStage stage)
        {
            switch (stage)
            {
                case TimerStage.Work: return "WORK";
                case TimerStage.Break: return "BREAK";
                default: return string.Empty;
            }
        }
    }

    public static class ObservableExtensions
    {
        public static T Find<T>(this ObservableCollection<T> list, Predicate<T> match)
        {
            for (int i = 0; i < list.Count; i++)
                if (match.Invoke(list[i]))
                    return list[i];

            return default(T);
        }

    }
}
