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
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Time_Owner
{

    public partial class StatisticsWindow : Window, INotifyPropertyChanged
    {
        private static StatisticsWindow _instance;

        public static StatisticsWindow GetInstance()
        {
            if (_instance == null)
                return _instance = new StatisticsWindow();
            else
                return _instance;
        }

        private SeriesCollection _seriesCollection;
        private string[] _labels;
        private StatisticType _statisticType;

        public SeriesCollection SeriesCollection
        {
            get { return _seriesCollection; }
            set { _seriesCollection = value;
                OnPropertyChanged("SeriesCollection");
            }
        }
        public string[] Labels
        {
            get { return _labels; }
            set { _labels = value;
                OnPropertyChanged("Labels");
            }
        } 

        public StatisticType StatisticType
        {
            get { return _statisticType; }
            set
            {
                _statisticType = value;
                SwitchDataType(value);
                OnPropertyChanged("StatisticType");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // For storage a loaded months
        public ObservableCollection<DateMonth> Months { get; set; } = new ObservableCollection<DateMonth>();

        public Func<double, string> Formatter { get; set; }


        private StatisticsWindow()
        {
            InitializeComponent();

            SetDefaultValues();

            InitializeCalendar();

            DataContext = this;
            chart.DataContext = this;

            Recalculate();
        }

        private void SetDefaultValues()
        {
            Labels = new string[5] { "1-6", "7-12", "13-18", "19-24", "25-31" };

            Formatter = value => $"{value} h";
        }

        private void InitializeCalendar()
        {
            var dates = FileManager.GetMonthsInFolder(GlobalSettings.pathData);

            calendar.possibleDates = dates;
        }

        private void SwitchDataType(StatisticType newType)
        {

            switch (newType)
            {
                case StatisticType.Default:
                    Labels = new string[5] { "1-6", "7-12", "13-18", "19-24", "25-31" };
                    break;

                case StatisticType.Dynamics:
                    string[] newLabels = new string[31];
                    for (int i = 1; i < 32; i++)
                        newLabels[i-1] = i.ToString();

                    Labels = newLabels;
                    break;
            }

            Recalculate();
        }

        private void LoadMonths()
        {
            Months.Clear();

            foreach (var date in calendar.selectedDates)
                Months.Add(FileManager.LoadDataMonth(GlobalSettings.pathData, date.month, date.year));
        }

        private void CreateChart()
        {
            var collection = new SeriesCollection();

            foreach (var m in Months)
            {
                ChartValues<double> vs = new ChartValues<double>();

                switch (StatisticType)
                {
                    case StatisticType.Default:

                        ColumnSeries column = new ColumnSeries() { Title = m.Title };

                        double val = 0;

                        for (int i=1; i<32; i++)
                        {
                            if (!m.values.ContainsKey(i))
                                continue;

                            TimeSpan time = m.values[i].allTimeOfWork;
                            val += Math.Round(time.TotalHours, 2);

                            if (i == 6 || i == 12 || i == 18 || i == 24 || i == 31)
                            {
                                vs.Add(val);
                                val = 0;
                            }
                        }

                        column.Values = vs;
                        collection.Add(column);

                        break;
                    case StatisticType.Dynamics:

                        LineSeries lineSeries = new LineSeries() { Title = m.Title };

                        for (int i = 1; i < 32; i++)
                        {
                            if (!m.values.ContainsKey(i))
                            {
                                vs.Add(0);
                                continue;
                            }

                            TimeSpan time = m.values[i].allTimeOfWork;
                            vs.Add(Math.Round(time.TotalHours, 2));
                        }

                        lineSeries.Values = vs;
                        collection.Add(lineSeries);
                        break;
                }
            }

            SeriesCollection = collection;
        }

        public new void Close()
        {
            _instance = null;
            base.Close();
        }

        protected void CloseClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// For drag the window
        /// </summary>
        private void moveRectangle_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed) 
                DragMove();
        }

        private void BtnRecalculate(object sender, RoutedEventArgs e)
        {
            Recalculate();
        }

        private void Recalculate()
        {
            LoadMonths();
            CreateChart();
        }

    }


    public enum StatisticType
    {
        Default = 0,
        Dynamics = 1
    }
}
