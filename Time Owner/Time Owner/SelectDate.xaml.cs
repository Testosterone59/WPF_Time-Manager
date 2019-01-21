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

namespace Time_Owner
{

    public partial class SelectDate : Window
    {

        private Action<SelectedDatesCollection> action_complete;

        public SelectDate()
        {
            InitializeComponent();
        }

        public bool? ShowDialog(Action<SelectedDatesCollection> action_complete)
        {
            this.action_complete = action_complete;
            return base.ShowDialog();
        }

        private void BtnOk(object sender, RoutedEventArgs e)
        {
            if (calendar.SelectedDate == null)
                return;

            action_complete(calendar.SelectedDates);
            Close();
        }

        private void BtnClose(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void moveRectangle_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }
}
