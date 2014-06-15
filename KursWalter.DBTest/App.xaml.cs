using KursWalter.Core.Persistence;
using MySql.Data.MySqlClient;
using System;
using System.Net.Mail;
using System.Windows;
using KursWalter.Core.Interfaces;
using KursWalter.Core.Classes;



namespace KursWalter.DBTest
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mySqlConnection = new DBConnection("localhost", "KursWalter", null, "root", "admin");

            if (!mySqlConnection.Connect())
            {
                Console.WriteLine(mySqlConnection.ErrorMessage);
                return;
            }
            else
            {
                Console.WriteLine("Connnected Successfully");
            }

            var Init = new InitializeDatabase(mySqlConnection);

            if (!Init.Init())
            {
                Console.WriteLine(Init.ErrorMessage);
            }

            var ModUser = new ModifyUser();
            ModUser.AddUser(new Person("WurstPeter", "Peter", "Wurst", "M", "Dr. Prof", "TellMeASecureStringPassword", new MailAddress("IlikeBigBoobs@horny.com"), new DateTime(1991, 6, 24)), mySqlConnection);

            string cmd = "SELECT * FROM persons;";
            MySqlCommand command = new MySqlCommand(cmd, mySqlConnection.Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0) + " | " + reader.GetString(1) + " | " + reader.GetString(2) + " | " + reader.GetString(3) + " | " + reader.GetString(4) + " | " + reader.GetString(5) + " | " + reader.GetString(6));
            }
            reader.Close();
            mySqlConnection.Disconnect();







            // Show MainWindow
            var mainwindow = new MainWindow();
            MainWindow = mainwindow;

            MainWindow.Show();
        }
    }
}
