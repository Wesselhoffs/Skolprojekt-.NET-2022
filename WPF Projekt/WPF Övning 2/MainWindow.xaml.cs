using System;
using System.Collections.Generic;
using System.IO;
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

namespace WPF_Övning_2
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

        private void saveFile_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult boxResult = MessageBox.Show("Vill du spara filen?\nDetta kommer skriva över eventuell gammal text i befintlig fil", "Spara fil", MessageBoxButton.YesNo);
                if (boxResult == MessageBoxResult.Yes)
                {
                    File.WriteAllText("Testfile.txt", myTextBox.Text);
                    MessageBox.Show("Testfile.txt sparad!", "Sparat filen");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void loadFile_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult boxResult = MessageBox.Show("Är du säker på att du vill ladda in textfilen?\nAll osparad text kommer gå förlorad.", "Ladda fil", MessageBoxButton.YesNo);
                if (boxResult == MessageBoxResult.Yes)
                {
                    if (File.Exists("Testfile.txt"))
                    {
                        myTextBox.Clear();
                        myTextBox.Text = File.ReadAllText("Testfile.txt");
                        MessageBox.Show("Testfile.txt laddad!", "Laddat filen");
                    }
                    else MessageBox.Show("Det finns ingen fil att ladda.\nSpara en fil, eller skapa en ny", "Filen finns inte");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void generateFile_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult boxResult = MessageBox.Show("Är du säker på att du vill skapa en ny blank fil?\n" +
                    "Detta kommer skriva över all eventuell text i befintlig fil.", "Skapa en ny fil", MessageBoxButton.YesNo);
                if (boxResult == MessageBoxResult.Yes)
                {
                    using (File.Create("Testfile.txt"))
                    {
                        myTextBox.Clear();
                        MessageBox.Show("Testfile.txt skapad!", "Skapat fil");
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void deleteFile_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult boxResult = MessageBox.Show("Vill du ta bort Testfile.txt?", "Ta bort fil", MessageBoxButton.YesNo);
                if (boxResult == MessageBoxResult.Yes)
                {
                    File.Delete("Testfile.txt");
                    myTextBox.Clear();
                    MessageBox.Show("Testfile.txt borttagen", "Ta bort fil");
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
