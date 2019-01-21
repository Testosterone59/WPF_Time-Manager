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

    public partial class WindowProgressBar : Window
    {
        public WindowProgressBar()
        {
            InitializeComponent();
            Initialization();
        }

        public void Initialization()
        {
            Width = GlobalSettings.dataSettings.ProgressbarWidth;
            Height = GlobalSettings.dataSettings.ProgressbarHeight;
            progressBar.Width = GlobalSettings.dataSettings.ProgressbarWidth;
            progressBar.Height = GlobalSettings.dataSettings.ProgressbarHeight;
        }

        public void SetValue(double val)
        {
            progressBar.Value = val;
        }

    }
}
