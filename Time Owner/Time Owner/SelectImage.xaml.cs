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

    public partial class SelectImage : UserControl
    {
        public static readonly DependencyProperty PathImageProperty = DependencyProperty.RegisterAttached(
               "PathImage", typeof(string), typeof(SelectImage));
        public string PathImage
        {
            get { return (string)GetValue(PathImageProperty); }
            set { SetValue(PathImageProperty, value); }
        }

        public static readonly DependencyProperty ClickProperty = DependencyProperty.RegisterAttached(
           "Click",
           typeof(RoutedEventHandler),
           typeof(SelectImage));

        public RoutedEventHandler Click
        {
            get { return (RoutedEventHandler)GetValue(ClickProperty); }
            set { SetValue(ClickProperty, value); }
        }

        public SelectImage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Click?.Invoke(this, e);
        }

    }
}
