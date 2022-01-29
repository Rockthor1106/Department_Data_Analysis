using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Collections;

namespace Department_Data_Analysis
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

        private void OpenFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            Student student = new Student();
            string[] StudentArray = new string[3];

            DataTable dt = new DataTable();
            dt.Columns.Add("Last Name", typeof(string));
            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Subject", typeof(string));

            using (StreamReader sr = new StreamReader(openFileDialog.FileName))
            {
                while(!sr.EndOfStream)
                {
                    StudentArray = sr.ReadLine().Split(";");
                    txtBox1.Text = sr.Readli
                }
            }
        }
    }
}
