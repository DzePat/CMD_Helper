using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CMD_Upgrade
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void HandleMouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is Ellipse ellipse)
            {
                Color color = (Color)ColorConverter.ConvertFromString("#F2AC61");
                ellipse.Fill = new SolidColorBrush(color);
                ellipse.Cursor = Cursors.Hand;
            }
        }

        private void HandleMouseLeave(object sender, MouseEventArgs e)
        {
            if (sender is Ellipse ellipse)
            {
                Color color = (Color)ColorConverter.ConvertFromString("#E81010");
                ellipse.Fill = new SolidColorBrush(color);
            }
        }
    }


}
