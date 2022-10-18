using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Media;

namespace WPF_Övning_3
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

        private void checkMyEmailButton_Click(object sender, RoutedEventArgs e)
        {
            Regex emailRegex = new Regex(@"^[a-zA-Z]\w*@\w+\.[a-zA-Z]{2,}$");
            if (emailRegex.IsMatch(emailTextBox.Text))
            {
                validOrNotTextBlock.Foreground = new SolidColorBrush(Colors.LawnGreen);
                validOrNotTextBlock.Text = "VALID EMAIL";
            }
            else
            {
                validOrNotTextBlock.Foreground = new SolidColorBrush(Colors.Red);
                validOrNotTextBlock.Text = "UNVALID EMAIL";
            }
        }
    }
}
