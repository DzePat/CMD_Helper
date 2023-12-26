using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CMD_Upgrade
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
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
    }
}