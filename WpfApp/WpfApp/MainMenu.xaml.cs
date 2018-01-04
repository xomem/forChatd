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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        private SimpleQueryResult SimpleQueryResult;

        Window MainWin;

        public MainMenu(Window MainWin)
        {
            InitializeComponent();
            this.MainWin = MainWin;
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            MainWin.Title = "Главное меню";
        }
        private void allEmploy_Click(object sender, RoutedEventArgs e)
        {
            //MainFrame.Content = new SimpleQueryResult();
            SimpleQueryResult = new SimpleQueryResult();
            NavigationService.Navigate(SimpleQueryResult);
            MainWin.Title = "Все сотрудники";
            //SimpleQueryResult.SQRDataGridXAML.Columns[0].Header = "ID сотрудника";
            //SimpleQueryResult.SQRDataGridXAML.Columns[1].Header = "Имя";
            //SimpleQueryResult.SQRDataGridXAML.Columns[2].Header = "Фамилия";
            //SimpleQueryResult.SQRDataGridXAML.Columns[3].Header = "Отчество";

        }



        private void allHDD_Click(object sender, RoutedEventArgs e)
        {
            SimpleQueryResult = new SimpleQueryResult();
            NavigationService.Navigate(SimpleQueryResult);
            MainWin.Title = "Все жёсткие диски";
            SimpleQueryResult.SQRDataGridXAML.Columns[0].Header = "ID ПК";
            SimpleQueryResult.SQRDataGridXAML.Columns[1].Header = "Фирма";
            SimpleQueryResult.SQRDataGridXAML.Columns[2].Header = "Серийный номер";
            SimpleQueryResult.SQRDataGridXAML.Columns[3].Header = "Объем";
        }

        private void allTech_Click(object sender, RoutedEventArgs e)
        {
            SimpleQueryResult = new SimpleQueryResult();
            NavigationService.Navigate(SimpleQueryResult);
            MainWin.Title = "Вся техника";
            SimpleQueryResult.SQRDataGridXAML.Columns[0].Header = "ID Технкии";
            SimpleQueryResult.SQRDataGridXAML.Columns[1].Header = "Тип";
            SimpleQueryResult.SQRDataGridXAML.Columns[2].Header = "Фирма";
            SimpleQueryResult.SQRDataGridXAML.Columns[3].Header = "Марка";
            SimpleQueryResult.SQRDataGridXAML.Columns[4].Header = "Номер ЦСО";
            SimpleQueryResult.SQRDataGridXAML.Columns[5].Header = "Серийный номер";
        }

        private void allCharac_Click(object sender, RoutedEventArgs e)
        {
            SimpleQueryResult = new SimpleQueryResult();
            NavigationService.Navigate(SimpleQueryResult);
            MainWin.Title = "Вся характиристики";
            SimpleQueryResult.SQRDataGridXAML.Columns[0].Header = "ID Технкии";
            SimpleQueryResult.SQRDataGridXAML.Columns[1].Header = "Фирма процессора";
            SimpleQueryResult.SQRDataGridXAML.Columns[2].Header = "Модель процессора";
            SimpleQueryResult.SQRDataGridXAML.Columns[3].Header = "Оперативная память";
            SimpleQueryResult.SQRDataGridXAML.Columns[4].Header = "Разрядность";
            SimpleQueryResult.SQRDataGridXAML.Columns[5].Header = "Операционная система";
        }
    }
}
