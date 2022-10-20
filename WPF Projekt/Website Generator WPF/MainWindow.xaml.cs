using Microsoft.Win32;
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
        private void Save_Website_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".html"; // Default file extension
            dlg.Filter = "Text documents (.html)|*.html"; // Filter files by ex
                                                        // Show save file dialog box
            Nullable<bool> result = dlg.ShowDialog();


            File.WriteAllText(dlg.FileName, Website_TextBlock.Text);

        }
        private void Load_Website_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.FileName = "Document"; // Default file name
            open.DefaultExt = ".html"; // Default file extension
            open.Filter = "Text documents (.html)|*.html"; // Filter files by ex
                                                           // Show save file dialog box

            Nullable<bool> result = open.ShowDialog();

            string temp = File.ReadAllText(open.FileName);
            Website_TextBlock.Text=temp;

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
