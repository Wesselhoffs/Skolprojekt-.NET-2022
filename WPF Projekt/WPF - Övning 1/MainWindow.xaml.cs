using System.Windows;

namespace WPF___Övning_1
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

        private void myOnlyButton_Click(object sender, RoutedEventArgs e)
        {
            string leftTemp = myLeftTextBox.Text;
            string rightTemp = myRightTextBox.Text;
            myLeftTextBox.Clear();
            myRightTextBox.Clear();
            myLeftTextBox.Text = rightTemp;
            myRightTextBox.Text = leftTemp;
        }
    }
}
