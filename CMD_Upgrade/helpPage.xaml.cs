using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CMD_Upgrade
{
    /// <summary>
    /// Interaction logic for helpPage.xaml
    /// </summary>
    public partial class helpPage : Page
    {
        public helpPage()
        {
            InitializeComponent();
        }

        private void closeButton(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;

            // Access the Frame element from the MainWindow
            if (mainWindow != null)
            {
                mainWindow.window1.Content = null;
            }
        }
    }
}
