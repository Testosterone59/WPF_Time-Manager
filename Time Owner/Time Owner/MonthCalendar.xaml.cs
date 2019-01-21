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

namespace Time_Owner
{

    public partial class MonthCalendar : UserControl
    {
        public static string[] MonthNames = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public static readonly DependencyProperty YearProperty = DependencyProperty.RegisterAttached(
           "Year",
           typeof(int),
           typeof(MonthCalendar));

        public static readonly DependencyProperty MaxElementsSelectedProperty = DependencyProperty.RegisterAttached(
           "MaxElementsSelected",
           typeof(int),
           typeof(MonthCalendar));

        public static readonly DependencyProperty OnChangeProperty = DependencyProperty.RegisterAttached(
           "OnChange",
           typeof(Action),
           typeof(MonthCalendar));

        public int Year
        {
            get { return (int)GetValue(YearProperty); }
            set { SetValue(YearProperty, value); }
        }

        public int MaxElementsSelected
        {
            get { return (int)GetValue(MaxElementsSelectedProperty); }
            set { SetValue(MaxElementsSelectedProperty, value); }
        }

        public Action OnChange
        {
            get { return (Action)GetValue(OnChangeProperty); }
            set { SetValue(OnChangeProperty, value); }
        }

        private readonly MonthCalendarElement[] instances = new MonthCalendarElement[12];

        public List<Date> selectedDates = new List<Date>();

        // The array for keep a possible dates , them will help to user quickly select months
        private List<Date> _possibleDates = new List<Date>();
        public List<Date> possibleDates
        {
            private get { return _possibleDates; }
            set { _possibleDates = value; UpdateElements(); }
        }

        public MonthCalendar()
        {
            InitializeComponent();
            Initialize();
            InitializeMonths();

            UpdateElements();

            DataContext = this;
        }

        private void InitializeMonths()
        {
            for (int row = 0; row < 3; row++)
                for (int column = 0; column < 4; column++)
                {
                    MonthCalendarElement newElement = new MonthCalendarElement();
                    int indexElement = row * 4 + column;

                    newElement.actionClick = () => ClickOnElement(indexElement);

                    newElement.Text = MonthNames[indexElement];
                    gridMonths.Children.Add(newElement);

                    Grid.SetRow(newElement, row);
                    Grid.SetColumn(newElement, column);

                    instances[indexElement] = newElement;
                }
        }

        private void Initialize()
        {
            DateTime currentTime = DateTime.Now;
            Year = currentTime.Year;

            if (MaxElementsSelected < 1)
                MaxElementsSelected = 1;

            selectedDates.Add(new Date() { month = currentTime.Month, year = Year });
        }

        private void UpdateElements()
        {
            for (int i=0; i< instances.Length; i++)
            {
                instances[i].IsSelected = selectedDates.Exists((d) => d.month == i + 1 && d.year == Year);
                instances[i].HasData = possibleDates.Exists((d) => d.month == i + 1 && d.year == Year);
            }
        }

        private void ClickOnElement(int index)
        {
            if (instances[index].IsSelected)
            {
                instances[index].Reselect();
                int indexDate = selectedDates.FindIndex((d) => d.month == index + 1 && d.year == Year);

                if (indexDate > -1)
                    selectedDates.RemoveAt(indexDate);
            }
            else if (selectedDates.Count < MaxElementsSelected)
            {
                instances[index].Reselect();
                selectedDates.Add(new Date() { month = index + 1, year = Year });
            }
            else
            {
                MessageBox.Show($"Cannot select more than {MaxElementsSelected} dates.", "Information", MessageBoxButton.OK);
                return;
            }

            OnChange?.Invoke();
            UpdateElements();
        }

        private void AddYear(int value)
        {
            if (value < 0 && Year <= 2015)
                return;

            Year += value;

            UpdateElements();
        }

        private void BtnPrevious(object sender, RoutedEventArgs e)
        {
            AddYear(-1);
        }

        private void BtnNext(object sender, RoutedEventArgs e)
        {
            AddYear(1);
        }
    }
}
