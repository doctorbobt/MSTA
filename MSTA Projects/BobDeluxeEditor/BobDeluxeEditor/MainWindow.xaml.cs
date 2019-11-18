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
using Microsoft.Win32;
using System.IO;

namespace BobDeluxeEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string currentFileName { get; set; }
        public bool TextChanged { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            currentFileName = String.Empty;
            TextChanged = false;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (currentFileName == String.Empty)
            {
                sfd.FileName = "Some New File";
                sfd.Filter = "Text documents (.txt)|*.txt";
                sfd.DefaultExt = ".txt";
            }
            else
            {
                sfd.FileName = currentFileName;
            }
            bool? result = sfd.ShowDialog();
            if (result == true)
            {
                File.WriteAllText(sfd.FileName, editor.Text);
                MessageBox.Show(sfd.FileName + " has been saved!");
                TextChanged = false;
            }
            else
            {
                MessageBox.Show("Content has NOT been saved!");
                return;
            }
        }
        private void load_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt) | *.txt";
            bool? result = ofd.ShowDialog();
            if (result == true)
            {
                string fileName = ofd.FileName;
                string input = File.ReadAllText(fileName);
                editor.Text = input;
                currentFileName = ofd.FileName;
                TextChanged = false;
            }
        }
        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Lose changes?", "Changes", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                editor.Text = String.Empty;
                currentFileName = String.Empty;
            }
            //else
            //{
            //    save_Click(this, new RoutedEventArgs());
            //}
        }
    private void exit_Click(object sender, RoutedEventArgs e)
    {
        if (TextChanged)
        {
            MessageBoxResult result = MessageBox.Show("Lose changes?", "Changes", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
                Environment.Exit(0);
            }
        }
    }
    private void editor_TextChanged(object sender, TextChangedEventArgs e)
    {
        TextChanged = true;
    }
}
}
