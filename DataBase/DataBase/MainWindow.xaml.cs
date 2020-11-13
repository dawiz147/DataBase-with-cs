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
using System.ComponentModel;

namespace DataBase
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PhpMyAdminDataBase database_connection_;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            database_connection_ = new PhpMyAdminDataBase(datasource_input.Text, port_input.Text, username_input.Text, database_input.Text);
            database_connection_.CheckConnect();
        }
        private void Window_Closing(object sender, CancelEventArgs e)
        {
            database_connection_.CloseChonnection();
        }
    }

}
