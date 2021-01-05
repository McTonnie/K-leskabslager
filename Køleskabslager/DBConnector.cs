using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace Køleskabslager
{
    class DBConnector
    {




        public static MySqlConnection con; //denne bruges når man vil åbne en forbindelse tiil databasen eller lukke den
        private static string server; //ip til database
        private static string database; //database navn
        private static string uid;  //username
        private static string password; //hvis ikke du kan regne den ud skal du ikke være programør

        public static string name = "Oliver";
        public static int age = 19;
        

        public static void DBconnect()
        {
            Initialize();
        }

        private static void Initialize()
        {
            server = "localhost";
            database = "køle";
            uid = "root";
            password = "nan62udd";
            string constring;
            constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            con = new MySqlConnection(constring);


        }

        public static bool Opencon()
        {
            try
            {
                con.Open();
                Console.WriteLine("Connected");
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact database administrator");

                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");

                        break;
                }
                return false;
            }
        }

        public static bool Closecon()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public static void Command(string command) //denne er til Insert Update og Delete
        {
        }

        public static void Insert()
        {

            MySqlCommand cmd = new MySqlCommand("insert into lager(navn, efternavn, vare, udløb) values ('" + Variabler.navn + "', '" + Variabler.efternavn + "', '" + Variabler.vare + "', '" + Variabler.dato + "');", con);
            cmd.ExecuteNonQuery();

        }
        public static void delete(string id)
        {

            MySqlCommand cmd = new MySqlCommand("delete from lager where id = " + id + ";", con);
            cmd.ExecuteNonQuery();

        }


    }
}
