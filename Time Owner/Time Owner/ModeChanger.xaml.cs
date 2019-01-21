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

    public partial class ModeChanger : UserControl
    {

        public static readonly DependencyProperty LeftImageProperty = DependencyProperty.RegisterAttached(
           "LeftImage",
           typeof(ImageSource),
           typeof(ModeChanger));

        public static readonly DependencyProperty RightImageProperty = DependencyProperty.RegisterAttached(
           "RightImage",
           typeof(ImageSource),
           typeof(ModeChanger));

        public static readonly DependencyProperty ClickProperty = DependencyProperty.RegisterAttached(
           "Click",
           typeof(RoutedEventHandler),
           typeof(ModeChanger));

        public static readonly DependencyProperty OnChangeProperty = DependencyProperty.RegisterAttached(
           "OnChange",
           typeof(Action<int>),
           typeof(ModeChanger));

        public static readonly DependencyProperty LeftToolTipProperty = DependencyProperty.RegisterAttached(
           "LeftToolTip",
           typeof(string),
           typeof(ModeChanger));

        public static readonly DependencyProperty RightToolTipProperty = DependencyProperty.RegisterAttached(
           "RightToolTip",
           typeof(string),
           typeof(ModeChanger));

        public ImageSource LeftImage
        {
            get { return (ImageSource)GetValue(LeftImageProperty); }
            set { SetValue(LeftImageProperty, value); }
        }

        public ImageSource RightImage
        {
            get { return (ImageSource)GetValue(RightImageProperty); }
            set { SetValue(RightImageProperty, value); }
        }

        public RoutedEventHandler Click
        {
            get { return (RoutedEventHandler)GetValue(ClickProperty); }
            set { SetValue(ClickProperty, value); }
        }

        public Action<int> OnChange
        {
            get { return (Action<int>)GetValue(OnChangeProperty); }
            set { SetValue(OnChangeProperty, value); }
        }

        public string LeftToolTip
        {
            get { return (string)GetValue(LeftToolTipProperty); }
            set { SetValue(LeftToolTipProperty, value); }
        }

        public string RightToolTip
        {
            get { return (string)GetValue(RightToolTipProperty); }
            set { SetValue(RightToolTipProperty, value); }
        }

        public int value = 0;

        public ModeChanger()
        {
            InitializeComponent();

        }

        private void ButtonLeft_Click(object sender, RoutedEventArgs e)
        {
            ChangeMode(0);
        }

        private void ButtonRight_Click(object sender, RoutedEventArgs e)
        {
            ChangeMode(1);
        }

        private void ChangeMode(int newValue)
        {
            if (value == newValue)
                return;

            value = newValue;

            MovePoint();
            OnChange?.Invoke(value);
        }
        /// <summary>
        /// Simple effect move
        /// </summary>
        private void MovePoint()
        {
            elipseInside.HorizontalAlignment = value == 0 ? HorizontalAlignment.Left : HorizontalAlignment.Right;
        }
    }
}
