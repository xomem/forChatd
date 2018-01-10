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
            try
            {
                var employers = Querys.readEmployers();
                mainWindow.successfulConnection();
                SimpleQueryResult = new SimpleQueryResult(employers);
                NavigationService.Navigate(SimpleQueryResult);
                MainWin.Title = "Все сотрудники";
            }
            catch (Exception ex)
            {
                mainWindow.errorConnection(ex);
            }
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
            NavigationService.Navigate(SimpleQueryResult);
            MainWin.Title = "Добавить сотрудника";
        }

        private void findEmployByRoom_Click(object sender, RoutedEventArgs e)
        {
            SearchEngine searchEngine = new SearchEngine();
            string str;
            bool hasInput = searchEngine.TryGetName("Поиск сотрудника по номеру кабинета", out str);
            if (hasInput)
            {
                SimpleQueryResult = new SimpleQueryResult(Querys.employByRoom(str));
            }
            NavigationService.Navigate(SimpleQueryResult);


            //searchWindow._searchType = Search.searchType.employByRoom;
        }
    }
}
