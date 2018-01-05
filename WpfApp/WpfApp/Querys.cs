using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Data;


namespace WpfApp
{
    public class Querys
    {
        //MainWindow MainWin;
        //private SimpleQueryResult SimpleQueryResult;
        //SqlConnection SqlConnection;

        static string ConnectionAdres = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Edward\source\repos\WpfApp\WpfApp\MainDatabase.mdf;Integrated Security=True";

        public static DataTable readEmployers()
        {
            var mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [employment]", ConnectionAdres);
                //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [employment] WHERE ID = 9", ConnectionAdres);
                DataTable dt = new DataTable("Call Reciept");
                da.Fill(dt);
                mainWindow.successfulConnection();
                return dt;
            }
            catch (Exception ex)
            {
                mainWindow.errorConnection(ex);
                return null;
            }
        }
        public static DataTable readHDD()
        {
            var mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [hardDrive]", ConnectionAdres);
                DataTable dt = new DataTable("Call Reciept");
                da.Fill(dt);
                mainWindow.successfulConnection();
                return dt;
            }
            catch (Exception ex)
            {
                mainWindow.errorConnection(ex);
                return null;
            }
        }
        public static DataTable readTech()
        {
            var mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [technic]", ConnectionAdres);
                DataTable dt = new DataTable("Call Reciept");
                da.Fill(dt);
                mainWindow.successfulConnection();
                return dt;
            }
            catch (Exception ex)
            {
                mainWindow.errorConnection(ex);
                return null;
            }
        }
        public static DataTable readSysCharacter()
        {
            var mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [systemCharacteristic]", ConnectionAdres);
                DataTable dt = new DataTable("Call Reciept");
                da.Fill(dt);
                mainWindow.successfulConnection();
                return dt;
            }
            catch (Exception ex)
            {
                mainWindow.errorConnection(ex);
                return null;
            }
        }



        //public async void connectDB(MainWindow MainWin)
        //{
        //    this.MainWin = MainWin;
        //    string ConnectionAdres = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Edward\source\repos\WpfApp\WpfApp\MainDatabase.mdf;Integrated Security=True";
        //    SqlConnection = new SqlConnection(ConnectionAdres);

        //    await SqlConnection.OpenAsync();

        //    SqlDataReader SQLDReader = null;

        //    SqlCommand GetAllEmployCommand = new SqlCommand("SELECT * FROM [employment]", SqlConnection);



        //    try
        //    {
        //        MainWin.Status.Content = "Подключено к БД";

        //        while (await SQLDReader.ReadAsync())
        //        {
        //            string test = Convert.ToString(SQLDReader["ID"]) + Convert.ToString(SQLDReader["surname"]) + Convert.ToString(SQLDReader["name"]) + Convert.ToString(SQLDReader["patronymic"]);
        //            MainWin.checkConnect(test);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MainWin.connectError(ex);
        //        MainWin.Status.Content = "Ошибка подключения к БД" + " - " + ex;
        //    }
        //    finally
        //    {
        //        if (SQLDReader != null)
        //        {
        //            SQLDReader.Close();
        //        }
        //    }
        //}

        //public void closeConnect()
        //{
        //    if (SqlConnection != null && SqlConnection.State != ConnectionState.Closed)
        //    {
        //        SqlConnection.Close();
        //        MainWin.Status.Content = "Подключение закрыто";
        //    }
        //}
    }
}
