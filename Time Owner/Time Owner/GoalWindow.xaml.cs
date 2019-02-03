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

    public partial class GoalWindow : Window
    {

        public static readonly DependencyProperty TargetProperty = DependencyProperty.RegisterAttached(
           "Goal",
           typeof(Goal),
           typeof(GoalWindow));

        public bool IsReady
        {
            get { return Goal.Name != string.Empty && Goal.dateEnd.HasValue; }
        }

        public Goal Goal
        {
            get { return (Goal)GetValue(TargetProperty); }
            set
            {
                SetValue(TargetProperty, value);
                BindingContext();
            }
        }

        /// <summary>
        /// It is executed when successful
        /// </summary>
        private Action<Goal> actionOfSuccess;

        public GoalWindow()
        {
            InitializeComponent();

            datePicker.DisplayDateStart = DateTime.Now.AddDays(1);
        }

        private void BindingContext()
        {
            goalNameText.DataContext = Goal;
            datePicker.DataContext = Goal;
        }

        public bool? ShowDialog(Action<Goal> actionOfSuccess, string defaultName = "New Goal", DateTime? defaultDate = null)
        {
            this.actionOfSuccess = actionOfSuccess;
            this.Goal = new Goal() { Name = defaultName, dateEnd = defaultDate };

            return base.ShowDialog();
        }

        private void BtnCancel(object sender, RoutedEventArgs e)
        {
            Close(); 
        }

        private void BtnOk(object sender, RoutedEventArgs e)
        {
            if (IsReady)
            {
                actionOfSuccess?.Invoke(Goal);
                Close();
            }
            else
            {
                MessageBox.Show("Please fill out completely",
                                          "Information",
                                          MessageBoxButton.OK,
                                          MessageBoxImage.Information);
            }

        }

        private void MyPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "!@#$*=".IndexOf(e.Text) >= 0;
        }
    }
}
