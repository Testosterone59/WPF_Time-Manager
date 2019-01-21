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

    public partial class TaskbarMessage : UserControl
    {

        public static readonly DependencyProperty TextProperty = DependencyProperty.RegisterAttached(
           "Text", typeof(string), typeof(TaskbarMessage));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public Action actionClick;

        public TaskbarMessage()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, MouseButtonEventArgs e)
        {
            actionClick?.Invoke();
        }
    }
}
