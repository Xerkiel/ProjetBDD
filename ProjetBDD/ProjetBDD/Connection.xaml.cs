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
using MySql.Data.MySqlClient;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;


namespace ProjetBDD
{
    /// <summary>
    /// Logique d'interaction pour Connection.xaml
    /// </summary>
    public partial class Connection : Page
    {
        public Connection()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string identifiant = IDBox.Text;
            string modDePasse = passewordBox.Password;

            string connectionString = "SERVER=localhost;PORT=3306;DATABASE=cooking;UID=root;PASSWORD=Manasoul78130;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Client;";

            MySqlDataReader reader;
            reader = command.ExecuteReader();

            bool next = true;
            bool verif = false;

            while (reader.Read() && next)
            {
                if (reader.GetValue(1).ToString() == identifiant && reader.GetValue(3).ToString() == modDePasse)
                {
                    Client user = new Client(Convert.ToInt32(reader.GetValue(0)), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), Convert.ToInt32(reader.GetValue(4)), Convert.ToBoolean(reader.GetValue(5)));

                    FileStream fs = new FileStream("DataFile.dat", FileMode.Create);
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, user);
                    fs.Close();

                    Console.WriteLine(Convert.ToInt32(reader.GetValue(0)));
                    next = false;
                    verif = true;
                }
                else if(verif == false)
                {

                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Inscription());
        }
    }
}
