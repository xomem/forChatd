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
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    /// 

    public partial class Search : Window
    {

        public Search()
        {
            InitializeComponent();
        }
        public enum searchType
        {
            techByEmploy,
            employByCSO,
            employByRoom,
            hddByEmploy
        }

        public searchType _searchType;

        private void search_Click(object sender, RoutedEventArgs e)
        {

            if (TextBox.Text != "")
            {
                if(_searchType == searchType.employByRoom)
                {
                    Querys.employByRoom(TextBox.Text);
                }
            }
            else
            {
                ErrorLabel.Content = "Поле должно быть заполнено";
            }
        }
    }
}
