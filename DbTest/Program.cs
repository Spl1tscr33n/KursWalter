using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using KursWalter.Core.Persistence;
using KursWalter.Core.Interfaces;
using KursWalter.Core.Classes;
using KursWalter.DataAccess.Classes;
using KursWalter.DataAccess.Interfaces;
using System.Net.Mail;
using MySql.Data.MySqlClient;


namespace KursWalter
{
    class Program
    {
        static void Main(string[] args)
        {
            CourseUnitOfWorkFactory factory = new CourseUnitOfWorkFactory();
            factory.Create();


            /*
            SecureString password = new SecureString();
            password.AppendChar('o');

            var Mysqlconnection = new DBConnection("localhost", "Kurswalter", "3306", "root", "1DDf33slnH?");
            if (!Mysqlconnection.Connect())
            {
                Console.WriteLine(Mysqlconnection.ErrorMessage);
            }
            else
            {
                Console.WriteLine("Connnected Successfully");
            }
            var Init = new InitializeDatabase(Mysqlconnection);

            if (!Init.Init())
            {
                Console.WriteLine(Init.ErrorMessage);
            }

            var ModUser = new ModifyUser();
            ModUser.AddUser(new Person("WurstPeter", "Peter", "Wurst", "M", "Dr. Prof", "TellMeASecureStringPassword", new MailAddress("IlikeBigBoobs@horny.com"), new DateTime(1991, 6, 24)), Mysqlconnection);

            string cmd = "SELECT * FROM persons;";
            MySqlCommand command = new MySqlCommand(cmd, Mysqlconnection.Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0) + " | " + reader.GetString(1) + " | " + reader.GetString(2) + " | " + reader.GetString(3) + " | " + reader.GetString(4) + " | " + reader.GetString(5) + " | " + reader.GetString(6));
            }
            reader.Close();
            Mysqlconnection.Disconnect();
            Console.ReadLine();
             * */
        }
    }
}
