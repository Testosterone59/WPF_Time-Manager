using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Time_Owner
{

    public static class GlobalSettings
    {
        public static DataSettings dataSettings = new DataSettings();

        private static double _elementTasksWidth = 360;
        private static double _elementTasksHeight = 28;

        private static double _modeSizeWindow = 1;

        public static double ElementTasksWidth
        {
            get { return _elementTasksWidth; }
        }
        public static double ElementTasksHeight
        {
            get { return _elementTasksHeight; }
        }
        public static double ElementTasksMinHeight
        {
            get { return _elementTasksHeight / 2; }
        }

        public static string pathData { get; set; }
        public static string pathLogs { get; set; }

        public static double ModeSizeWindow
        {
            get { return _modeSizeWindow; }
        }

        public static void InitializePathes()
        {
            pathData = $"{Directory.GetCurrentDirectory()}/Data/";
            pathLogs = $"{Directory.GetCurrentDirectory()}/Logs/";

            if (!Directory.Exists(pathData))
                Directory.CreateDirectory(pathData);
        }

        public static void UpdateElementTasksValues(double height, double width)
        {
            _elementTasksHeight = height;
            _elementTasksWidth = width;
        }

        /// <summary>
        /// Subclass for keep of the user data of settings
        /// </summary>
        public class DataSettings : DependencyObject
        {
            // Mode is Pomodoro 

            public static readonly DependencyProperty TimeOfWorkProperty = DependencyProperty.Register(
               "TimeOfWork", typeof(int), typeof(DataSettings));
            public int TimeOfWork
            {
                get { return (int)GetValue(TimeOfWorkProperty); }
                set { SetValue(TimeOfWorkProperty, value); }
            }
            public const int _timeOfWork = 25;

            public static readonly DependencyProperty TimeOfBreakProperty = DependencyProperty.Register(
               "TimeOfBreak", typeof(int), typeof(DataSettings));
            public int TimeOfBreak
            {
                get { return (int)GetValue(TimeOfBreakProperty); }
                set { SetValue(TimeOfBreakProperty, value); }
            }
            public const int _timeOfBreak = 5;

            public static readonly DependencyProperty TimeOfLongBreakProperty = DependencyProperty.Register(
               "TimeOfLongBreak", typeof(int), typeof(DataSettings));
            public int TimeOfLongBreak
            {
                get { return (int)GetValue(TimeOfLongBreakProperty); }
                set { SetValue(TimeOfLongBreakProperty, value); }
            }
            public const int _timeOfLongBreak = 30;

            // Mode is the Timer

            public static readonly DependencyProperty TimeOfGettingTomatoProperty = DependencyProperty.Register(
               "TimeOfGettingTomato", typeof(int), typeof(DataSettings));
            public int TimeOfGettingTomato
            {
                get { return (int)GetValue(TimeOfGettingTomatoProperty); }
                set { SetValue(TimeOfGettingTomatoProperty, value); }
            }
            public const int _timeOfGettingTomato = 25;

            public static readonly DependencyProperty MaximumTaskTimeProperty = DependencyProperty.Register(
               "MaximumTaskTime", typeof(int), typeof(DataSettings));
            public int MaximumTaskTime
            {
                get { return (int)GetValue(MaximumTaskTimeProperty); }
                set { SetValue(MaximumTaskTimeProperty, value); }
            }

            // Progress Bar settings

            public static readonly DependencyProperty ProgressbarWidthProperty = DependencyProperty.Register(
               "ProgressbarWidth", typeof(double), typeof(DataSettings));
            public double ProgressbarWidth
            {
                get { return (double)GetValue(ProgressbarWidthProperty); }
                set { SetValue(ProgressbarWidthProperty, value); }
            }

            public static readonly DependencyProperty ProgressbarHeightProperty = DependencyProperty.Register(
               "ProgressbarHeight", typeof(double), typeof(DataSettings));
            public double ProgressbarHeight
            {
                get { return (double)GetValue(ProgressbarHeightProperty); }
                set { SetValue(ProgressbarHeightProperty, value); }
            }

            // Other settings

            public static readonly DependencyProperty EnableWindowBreakProperty = DependencyProperty.Register(
               "EnableWindowBreak", typeof(bool), typeof(DataSettings));
            public bool EnableWindowBreak
            {
                get { return (bool)GetValue(EnableWindowBreakProperty); }
                set { SetValue(EnableWindowBreakProperty, value); }
            }

            public static readonly DependencyProperty EnableWindowInfoProperty = DependencyProperty.Register(
               "EnableWindowInfo", typeof(bool), typeof(DataSettings));
            public bool EnableWindowInfo
            {
                get { return (bool)GetValue(EnableWindowInfoProperty); }
                set { SetValue(EnableWindowInfoProperty, value); }
            }

            public static readonly DependencyProperty EnableProgressbarProperty = DependencyProperty.Register(
               "EnableProgressbar", typeof(bool), typeof(DataSettings));
            public bool EnableProgressbar
            {
                get { return (bool)GetValue(EnableProgressbarProperty); }
                set { SetValue(EnableProgressbarProperty, value); }
            }

            // Images

            public static readonly DependencyProperty PathImgBreakTimeProperty = DependencyProperty.Register(
               "PathImgBreakTime", typeof(string), typeof(DataSettings));
            public string PathImgBreakTime
            {
                get
                {
                    string v = (string)GetValue(PathImgBreakTimeProperty);
                    if (string.IsNullOrEmpty(v))
                        return PathImgBreakTime = "/Images/imgBreakTime.jpg";
                    else
                        return v;
                }
                set { SetValue(PathImgBreakTimeProperty, value); }
            }

            public static readonly DependencyProperty PathImgLongBreakTimeProperty = DependencyProperty.Register(
               "PathImgLongBreakTime", typeof(string), typeof(DataSettings));
            public string PathImgLongBreakTime
            {
                get
                {
                    string v = (string)GetValue(PathImgLongBreakTimeProperty);
                    if (string.IsNullOrEmpty(v))
                        return PathImgLongBreakTime = "/Images/imgLongBreakTime.jpg";
                    else
                        return v;
                }
                set { SetValue(PathImgLongBreakTimeProperty, value); }
            }

            public static readonly DependencyProperty PathImgProfileProperty = DependencyProperty.Register(
               "PathImgProfile", typeof(string), typeof(DataSettings));
            public string PathImgProfile
            {
                get
                {
                    string v = (string)GetValue(PathImgProfileProperty);
                    if (string.IsNullOrEmpty(v))
                        return PathImgProfile = "/Images/profile.png";
                    else
                        return v;
                }
                set { SetValue(PathImgProfileProperty, value); }
            }

            public DataSettings()
            {

                // Set default values
                TimeOfWork = _timeOfWork;
                TimeOfBreak = _timeOfBreak;
                TimeOfLongBreak = _timeOfLongBreak;
                TimeOfGettingTomato = _timeOfGettingTomato;

                PathImgBreakTime = "/Images/imgBreakTime.jpg";
                PathImgLongBreakTime = "/Images/imgLongBreakTime.jpg";
                PathImgProfile = "/Images/profile.png";


                EnableWindowInfo = true;
                EnableWindowBreak = true;
                EnableProgressbar = true;

                ProgressbarWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
                ProgressbarHeight = 5;
            }
        }

    }


}
