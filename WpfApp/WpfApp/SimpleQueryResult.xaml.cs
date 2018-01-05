﻿using System;
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
using System.Data;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for SimpleQueryResult.xaml
    /// </summary>
    public partial class SimpleQueryResult : Page
    {
        public SimpleQueryResult(DataTable dt)
        {
            InitializeComponent();
            
            SQRDataGridXAML.ItemsSource = dt.DefaultView;
            SQRDataGridXAML.IsReadOnly = true;
            SQRDataGridXAML.ColumnWidth = new DataGridLength(1, DataGridLengthUnitType.Star);
        }


        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
