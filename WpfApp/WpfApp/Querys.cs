using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Controls;

namespace WpfApp
{
    public class Querys
    {
        MainWindow MainWin;
        private SimpleQueryResult SimpleQueryResult;

        SqlConnection SqlConnection;
        public async void connectDB(MainWindow MainWin)
        {
            this.MainWin = MainWin;
            string ConnectionAdres = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Edward\source\repos\WpfApp\WpfApp\MainDatabase.mdf;Integrated Security=True";
            SqlConnection = new SqlConnection(ConnectionAdres);

            await SqlConnection.OpenAsync();

            SqlDataReader SQLDReader = null;

            SqlCommand GetAllEmployCommand = new SqlCommand("SELECT * FROM [employment]", SqlConnection);
            SimpleQueryResult = new SimpleQueryResult();


            
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [employment]", SqlConnection);
                DataTable dt = new DataTable("Call Reciept");
                da.Fill(dt);

                SimpleQueryResult.SQRDataGridXAML.ItemsSource = dt.DefaultView;

                SQLDReader = await GetAllEmployCommand.ExecuteReaderAsync();
                MainWin.Status.Content = "Подключено к БД";

                while (await SQLDReader.ReadAsync())
                {
                    string test = Convert.ToString(SQLDReader["ID"]) + Convert.ToString(SQLDReader["surname"]) + Convert.ToString(SQLDReader["name"]) + Convert.ToString(SQLDReader["patronymic"]);
                    //SimpleQueryResult.SQRDataGridXAML.ItemsSource = ;

                    MainWin.checkConnect(test);
                }

            }
            catch (Exception ex)
            {
                MainWin.connectError(ex);
                MainWin.Status.Content = "Ошибка подключения к БД" + " - " + ex;
            }
            finally
            {
                if (SQLDReader != null)
                {
                    SQLDReader.Close();
                }
            }
        }

        public void closeConnect()
        {
            if (SqlConnection != null && SqlConnection.State != ConnectionState.Closed)
            {
                SqlConnection.Close();
                MainWin.Status.Content = "Подключение закрыто";
            }
        }

        public void allEmployQuery()
        {

        }
    }
}
