﻿using System;
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
using LiveCharts;
using LiveCharts.Wpf;

namespace Department_Data_Analysis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Department> departmentList = new List<Department>();
        private List<Municipality> municipalityList = new List<Municipality>();

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
                    municipalityList.Add(new Municipality(values[3], Int32.Parse(values[1]), values[4]));
                }

                foreach (Department department in departmentList)
                {
                    DepartmentColumn.Items.Add(department.Name);
                    DepartmentCodeColumn.Items.Add(department.Code);
                }

                foreach (Municipality municipality in municipalityList)
                {
                    MunicipalityColumn.Items.Add(municipality.Name);
                    MunicipalityCodeColumn.Items.Add(municipality.Code);
                    TypeColumn.Items.Add(municipality.Type);
                }

                for (int i = 0; i < departmentList.Count; i++)
                {
                    if (!DepartmentCB.Items.Contains(departmentList[i].Name))
                    {
                        DepartmentCB.Items.Add(departmentList[i].Name);
                    }

                    if (!DepartmentCodeCB.Items.Contains(departmentList[i].Code))
                    {
                        DepartmentCodeCB.Items.Add(departmentList[i].Code);
                    }
                }

                for (int i = 0; i < municipalityList.Count; i++)
                {
                    if (!MunicipalityCB.Items.Contains(municipalityList[i].Name))
                    {
                        MunicipalityCB.Items.Add(municipalityList[i].Name);
                    }

                    if (!MunicipalityCodeCB.Items.Contains(municipalityList[i].Code))
                    {
                        MunicipalityCodeCB.Items.Add(municipalityList[i].Code);
                    }

                    if (!TypeCB.Items.Contains(municipalityList[i].Type))
                    {
                        TypeCB.Items.Add(municipalityList[i].Type);
                    }
                }


            }
        }

        private void DepartmentCodeCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DepartmentCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DepartmentColumn != null && MunicipalityCodeColumn != null)
            {
                DepartmentColumn.Items.Clear();
                DepartmentCodeColumn.Items.Clear();

                foreach (Department department in departmentList)
                {
                    if (DepartmentCB.SelectedItem.Equals(department.Name))
                    {
                        DepartmentColumn.Items.Add(department.Name);
                        DepartmentCodeColumn.Items.Add(department.Code);
                    }
                }

            }
        }

        private void TypeCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TypeColumn != null)
            {
                TypeColumn.Items.Clear();

                foreach (Municipality municipality in municipalityList)
                {
                    if (TypeCB.SelectedItem.Equals(municipality.Type)) {
                        TypeColumn.Items.Add(municipality.Type);
                    }
                }
            }
        }
    }
}
