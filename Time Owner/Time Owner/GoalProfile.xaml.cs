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

    public partial class GoalProfile : UserControl
    {
        public static readonly DependencyProperty GoalProperty = DependencyProperty.RegisterAttached(
           "Goal",
           typeof(Goal),
           typeof(GoalProfile),
           new FrameworkPropertyMetadata(new PropertyChangedCallback(GoalPropertyChangedCallback)));

        public static readonly DependencyProperty NumberProperty = DependencyProperty.RegisterAttached(
           "Number",
           typeof(string),
           typeof(GoalProfile));

        public Goal Goal
        {
            get { return (Goal)GetValue(GoalProperty); }
            set { SetValue(GoalProperty, value); MainWindow.dataChanged = true; }
        }

        public string Number
        {
            get { return (string)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }

        delegate void GoalChanged(DependencyObject d, DependencyPropertyChangedEventArgs e);
        event GoalChanged OnGoalChanged;

        static void GoalPropertyChangedCallback(DependencyObject t, DependencyPropertyChangedEventArgs e)
        {
            if (((GoalProfile)t).OnGoalChanged != null)
                ((GoalProfile)t).OnGoalChanged(t, e);
        }

        // When a property is updated, this event invoked.
        private void ActionTargetChanged(DependencyObject t, DependencyPropertyChangedEventArgs e)
        {
            dockPanel.Visibility = Goal == null ? Visibility.Hidden : Visibility.Visible;
            dockPanelEmpty.Visibility = Goal == null ? Visibility.Visible : Visibility.Hidden;
        }

        public GoalProfile()
        {
            InitializeComponent();
            OnGoalChanged += ActionTargetChanged;
        }

        private void BtnAdd(object sender, RoutedEventArgs e)
        {
            GoalWindow window = new GoalWindow();
            if (window.ShowDialog((t) => Goal = t) == true) { }
        }

        private void BtnRemove(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"Are you sure?", "Delete Goal", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                Goal = null;
        }
    }
}
