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

    public partial class TaskWindow : Window
    {
        private DataTask task;

        private Action ev_complete;

        public TaskWindow()
        {
            InitializeComponent();
        }
        public bool? ShowDialog(DataTask task, Action ev_complete)
        {
            this.task = task;
            this.ev_complete = ev_complete;
            taskName.Text = task.TaskName;
            if (task.Info != string.Empty) { taskDescription.AppendText(task.Info); }
            return base.ShowDialog();
        }

        private void BtnOk(object sender, RoutedEventArgs e)
        {
            task.TaskName = taskName.Text;
            task.Info = taskDescription.DocumentToString();
            ev_complete?.Invoke();
            Close();
        }

        private void BtnCancel(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MyPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "!@#$*=".IndexOf(e.Text) >= 0;
        }
    }
}
