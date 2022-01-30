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
using Department_Data_Analysis.model;

namespace Department_Data_Analysis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Department> departmentList = new List<Department>();
        private List<Municipality> munipalityList = new List<Municipality>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void importData_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            using (var reader = new StreamReader(openFileDialog.FileName))
            {
          
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    departmentList.Add(new Department(values[2], Int32.Parse(values[0])));
                    munipalityList.Add(new Municipality(values[3], Int32.Parse(values[1])));
                }

                foreach (Department department in departmentList)
                {
                    DepartmentColumn.Items.Add(department.Name);
                    DepartmentCodeColumn.Items.Add(department.Code);
                }

                foreach (Municipality municipality in munipalityList)
                {
                    MunicipalityColumn.Items.Add(municipality.Name);
                    MunicipalityCodeColumn.Items.Add(municipality.Code);
                }

                for (int i = 0; i < departmentList.Count; i++)
                {
                    if (!DepartmentCB.Items.Contains(departmentList[i].Name))
                    {
                        DepartmentCB.Items.Add(departmentList[i].Name);
                    }
                }

            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
