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
using System.Text.RegularExpressions;

namespace Time_Owner
{

    public partial class Settings : Window
    {

        public Settings()
        {
            InitializeComponent();
        }

        private void PreviewTextInputNumeric(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void CloseClick(object sender, RoutedEventArgs e)
        {
            FileManager.SaveSettings();
            Close();
        }

        private void OpenImageClick(object sender, RoutedEventArgs e)
        {
            SelectImage image = (SelectImage)sender;

            switch (image.Name)
            {
                case "selectImgBreakTime": OpenImage(value =>
                GlobalSettings.dataSettings.PathImgBreakTime = value); break;
                case "selectImgLongBreakTime": OpenImage(value =>
                GlobalSettings.dataSettings.PathImgLongBreakTime = value); break;
                case "selectImgProfile": OpenImage(value =>
                GlobalSettings.dataSettings.PathImgProfile = value); break;
            }
        }

        /// <summary>
        /// Open and select image in folder with help a special window
        /// </summary>
        /// <param name="pathTarget">Variable which will keep a path value</param>
        private void OpenImage(Action<string> setOutput)
        {
            string path = FileManager.OpenImage();
            if (path != string.Empty)
                setOutput(path);
        }

        private void moveRectangle_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

    }
}
