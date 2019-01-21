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

    public partial class WindowRest : Window
    {
        public static readonly DependencyProperty PathImageProperty = DependencyProperty.RegisterAttached(
           "PathImage", typeof(string), typeof(WindowRest));
        public string PathImage
        {
            get { return (string)GetValue(PathImageProperty); }
            set { SetValue(PathImageProperty, value); }
        }

        public WindowRest()
        {
            InitializeComponent();
        }

        public void SetTimerData(int minutes, int seconds)
        {
            textTimer.Text = $"{minutes}:{seconds}";
        }

        private void BtnClose(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
