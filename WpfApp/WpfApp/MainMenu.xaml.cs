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
        MainWindow mainWindow = new MainWindow();
        public MainMenu(Window MainWin)
        {
            InitializeComponent();
            this.MainWin = MainWin;
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            MainWin.Title = "Главное меню";      
        }
        public void navigateToSQR()
        {
            NavigationService.Navigate(SimpleQueryResult);
        }
        private void allEmploy_Click(object sender, RoutedEventArgs e)
        {
            //MainFrame.Content = new SimpleQueryResult();
            SimpleQueryResult = new SimpleQueryResult(Querys.readEmployers());
            NavigationService.Navigate(SimpleQueryResult);
            MainWin.Title = "Все сотрудники";
        }

        

        private void allHDD_Click(object sender, RoutedEventArgs e)
        {
            //SimpleQueryResult = new SimpleQueryResult();
            SimpleQueryResult = new SimpleQueryResult(Querys.readHDD());
            NavigationService.Navigate(SimpleQueryResult);
            MainWin.Title = "Все жёсткие диски";
        }

        private void allTech_Click(object sender, RoutedEventArgs e)
        {
            //SimpleQueryResult = new SimpleQueryResult();
            SimpleQueryResult = new SimpleQueryResult(Querys.readTech());
            NavigationService.Navigate(SimpleQueryResult);
            MainWin.Title = "Вся техника";
        }

        private void allCharac_Click(object sender, RoutedEventArgs e)
        {
            //SimpleQueryResult = new SimpleQueryResult();
            SimpleQueryResult = new SimpleQueryResult(Querys.readSysCharacter());
            NavigationService.Navigate(SimpleQueryResult);
            MainWin.Title = "Вся характиристики";
        }

        private void addEmploy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void findEmployByRoom_Click(object sender, RoutedEventArgs e)
        {
            Search searchWindow = new Search();
            searchWindow.TitleLabel.Content = "Поиск сотрудника по кабинету";
            searchWindow._searchType = Search.searchType.employByRoom;
            searchWindow.Show();
        }
    }
}
