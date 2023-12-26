
using Microsoft.Win32;
using System.Diagnostics;
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

        private void helpButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;

            // Access the Frame element from the MainWindow
            if (mainWindow != null)
            {
                mainWindow.window1.Content = new helpPage();
            }
        }

        private void runClick(object sender, MouseButtonEventArgs e)
        {
            int lineNumber = 0;
            Process oProcess = new Process();
            lineNumber = 0;
            oProcess.StartInfo.FileName = "cmd.exe";
            oProcess.StartInfo.RedirectStandardInput = true;
            oProcess.StartInfo.RedirectStandardOutput = true;
            oProcess.StartInfo.RedirectStandardError = true;
            oProcess.StartInfo.CreateNoWindow = true;
            oProcess.StartInfo.UseShellExecute = false;
            string command = commandInput.Text;
            string line = "";
            //Debug.WriteLine(command);
            oProcess.Start();
            oProcess.StandardInput.WriteLine($"{command}");
            oProcess.StandardInput.Flush();
            oProcess.StandardInput.Close();
            oProcess.WaitForExit();
            //lineNumber = 0;
            //output.Text = ""; //empty string
            /*while ((line = oProcess.StandardError.ReadLine()) != null)
            {
            output.Text = $"E{lineNumber}: {line}\n";
            lineNumber++;
            }
            if (lineNumber == 0) //there is no Error
            {
            lineNumber = 0;
            while ((line = oProcess.StandardOutput.ReadLine()) != null)
            {
            output.Text += $"{lineNumber}: {line}\n";
           lineNumber++;
            }
            }*/
            outputDisplay.Text += oProcess.StandardOutput.ReadToEnd() + "\n----------------\n\n";
        }
        private void browseClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.ShowDialog();
        }
    }
}
