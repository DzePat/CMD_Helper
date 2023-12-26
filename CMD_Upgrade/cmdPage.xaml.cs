
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CMD_Upgrade
{
    /// <summary>
    /// Interaction logic for cmdPage.xaml
    /// </summary>
    public partial class cmdPage : Page
    {
        public cmdPage()
        {
            InitializeComponent();
        }

        private void HandleMouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is Rectangle rectangle)
            {
                Color color = (Color)ColorConverter.ConvertFromString("#FF4040");
                rectangle.Fill = new SolidColorBrush(color);
                rectangle.Cursor = Cursors.Hand;
            }
        }

        private void HandleMouseLeave(object sender, MouseEventArgs e)
        {
            if (sender is Rectangle rectangle)
            {
                Color color = (Color)ColorConverter.ConvertFromString("#000000");
                rectangle.Fill = new SolidColorBrush(color);
            }
        }

        private void HandleBrowseEnter(object sender, MouseEventArgs e)
        {
            browseButton.Source = new BitmapImage(new Uri("C:\\Users\\Dzedas\\source\\repos\\CMD_Upgrade\\CMD_Upgrade\\browseImageHover.png"));
            browseButton.Cursor = Cursors.Hand;
        }

        private void HandleBrowseLeave(object sender, MouseEventArgs e)
        {
            browseButton.Source = new BitmapImage(new Uri("C:\\Users\\Dzedas\\source\\repos\\CMD_Upgrade\\CMD_Upgrade\\browseImage.png"));
            browseButton.Cursor = Cursors.Hand;
        }

        private void helpButtonClick(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;

            // Access the Frame element from the MainWindow
            if (mainWindow != null)
            {
                mainWindow.window1.Content = new helpPage();
            }
        }
    }
}
