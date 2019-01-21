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

    public partial class MonthCalendarElement : UserControl
    {

        public static readonly DependencyProperty TextProperty = DependencyProperty.RegisterAttached(
           "Text",
           typeof(string),
           typeof(MonthCalendarElement));

        public static readonly DependencyProperty HasDataProperty = DependencyProperty.RegisterAttached(
           "HasData",
           typeof(bool),
           typeof(MonthCalendarElement));

        public static readonly DependencyProperty IsSelectedProperty = DependencyProperty.RegisterAttached(
           "IsSelected",
           typeof(bool),
           typeof(MonthCalendarElement));

        public bool HasData
        {
            get { return (bool)GetValue(HasDataProperty); }
            set { SetValue(HasDataProperty, value); }
        }

        public bool IsSelected
        {
            get { return (bool)GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set
            {
                // Limit a value length
                string newValue = value.Length > 3 ? value.Substring(0, 3) : value;
                SetValue(TextProperty, newValue);
            }
        }

        public Action actionClick;

        public MonthCalendarElement()
        {
            InitializeComponent();

            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            actionClick?.Invoke();
        }

        public void Reselect()
        {
            IsSelected = !IsSelected;
        }
    }
}
