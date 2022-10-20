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
using Website_Generator_WPF.Classes;
using Website_Generator_WPF.Interfaces;

namespace Website_Generator_WPF
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

        private void show_Website_Click(object sender, RoutedEventArgs e)
        {
            Website_TextBlock.Text = GetText();
        }
        private void show_StyledWebsite_Click(object sender, RoutedEventArgs e)
        {
            Website_TextBlock.Text = GetStyledText();
        }

        private string GetStyledText()
        {
            string[] messagesToClass = { "Glöm inte att övning ger färdighet!", "Öppna boken på sida 257." };
            string[] techniques = { "C#", "Clean Code", "Databaser" };
            StyledWebsiteGenerator styledWebsiteGenerator = new StyledWebsiteGenerator("Klass A", "turqouise", messagesToClass, techniques);

            return styledWebsiteGenerator.PrintPage();
        }

        string GetText()
        {
            string[] messagesToClass = { "Glöm inte att övning ger färdighet!", "Öppna boken på sida 257." };
            string[] techniques = { "C#", "Clean Code", "Databaser" };
            WebsiteGenerator website = new WebsiteGenerator("Klass A", messagesToClass, techniques);

            string text = website.PrintPage();

            return text;
        }

    }
}
