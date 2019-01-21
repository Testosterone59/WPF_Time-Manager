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

    public partial class ButtonImage : UserControl
    {

        public static readonly DependencyProperty ImageDefaultProperty = DependencyProperty.RegisterAttached(
            "ImageDefault",
            typeof(ImageSource),
            typeof(ButtonImage));

        public static readonly DependencyProperty ImagePressedProperty = DependencyProperty.RegisterAttached(
           "ImagePressed",
           typeof(ImageSource),
           typeof(ButtonImage));

        public static readonly DependencyProperty ClickProperty = DependencyProperty.RegisterAttached(
           "Click",
           typeof(RoutedEventHandler),
           typeof(ButtonImage));

        public ImageSource ImageDefault
        {
            get { return (ImageSource)GetValue(ImageDefaultProperty); }
            set { SetValue(ImageDefaultProperty, value); }
        }

        public ImageSource ImagePressed
        {
            get { return (ImageSource)GetValue(ImagePressedProperty); }
            set { SetValue(ImagePressedProperty, value); }
        }

        public RoutedEventHandler Click
        {
            get { return (RoutedEventHandler)GetValue(ClickProperty); }
            set { SetValue(ClickProperty, value); }
        }

        public ButtonImage()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Click?.Invoke(sender, e);
        }

    }
}
