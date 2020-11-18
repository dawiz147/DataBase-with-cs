using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Interface;
using MySql.Data.MySqlClient;
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
namespace DataBase
{
    class PhpMyAdminDataBase: INterfaceDataBase
    {
        public PhpMyAdminDataBase(string datasource,string port,string username,string database)
        {
            MySQLConnectionString_ = "datasource=" + datasource + ";" + "port=" + port + ";" + "username=" + username + ";" + "database=" + database;
            Console.WriteLine(MySQLConnectionString_);
        }


        public void CheckConnect()
        {
            mySqlConnection = new MySqlConnection(MySQLConnectionString_);
            mySqlConnection.Open();
            
            if (mySqlConnection.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show(" connection sucessfull ");
            }
            else
            {
                MessageBox.Show(" XXX ");
            }
        }

        public void CloseChonnection()
        {
            mySqlConnection.Close();
        }

        private string MySQLConnectionString_ = "";
        private MySqlConnection mySqlConnection;
    }
}
