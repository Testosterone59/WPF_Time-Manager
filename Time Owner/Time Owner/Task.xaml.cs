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

    public partial class Task : UserControl
    {

        public static readonly DependencyProperty DataTaskProperty = DependencyProperty.Register(
           "DataTask", typeof(DataTask), typeof(Task));
        public DataTask DataTask
        {
            get { return (DataTask)GetValue(DataTaskProperty); }
            set { SetValue(DataTaskProperty, value); }
        }

        static SolidColorBrush colorSelect = new SolidColorBrush(Color.FromRgb(65, 65, 65));
        static SolidColorBrush colorUnselect = new SolidColorBrush(Color.FromRgb(57, 57, 57));

        Action onCheckBoxClick;
        Action<Task> onSelect;
        public Action onRemove;

        public Task(DataTask task, Action onCheckBoxClick, Action<Task> onSelect)
        {
            DataTask = task;
            task.gui = this;
            this.onCheckBoxClick = onCheckBoxClick;
            this.onSelect = onSelect;
            InitializeComponent();

            checkBox.Click += delegate (object sender, RoutedEventArgs e) { onCheckBoxClick?.Invoke(); };
            DataContext = DataTask; 
        }

        public void Remove()
        {
            onRemove?.Invoke();
        }

        private void OnClickEdit(object sender, RoutedEventArgs e)
        {
            MainWindow._singleton.OnEditTask(this);
        }

        private void OnClickDelete(object sender, RoutedEventArgs e)
        {
            MainWindow._singleton.OnDeleteTask(this);
        }

        private void OnClickCopy(object sender, RoutedEventArgs e)
        {
            MainWindow._singleton.CopySelectedTasksInBuffer();
        }

        private void OnClickCopyInto(object sender, RoutedEventArgs e)
        {
            MainWindow._singleton.CopyTasksInto();
        }

        public void OnSelect()
        {
            grid.Background = colorSelect;
        }

        public void OnUnselect()
        {
            grid.Background = colorUnselect;
        }

        /// <summary>
        /// Method of selection a task
        /// </summary>
        private void OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            onSelect?.Invoke(this); 
        }
    }
}
