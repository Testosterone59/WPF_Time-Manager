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

    public partial class WindowInfo : Window
    {

        private Action action;

        public WindowInfo(Action actionEnd)
        {
            InitializeComponent();
            action = actionEnd;
        }

        private void BtnOk(object sender, RoutedEventArgs e)
        {
            action?.Invoke();
            Close();
        }
    }
}
