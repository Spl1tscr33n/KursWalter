using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurswalter.Core.Interfaces;
using MySql.Data.MySqlClient;

namespace Kurswalter.Core.Persistence
{
    public class ModifyUser : IModifyUser
    {
        private string _errorMessage = null;
        public IDBConnection Connection { get; set; }
        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
        }
        public ModifyUser() { }
        public ModifyUser(IDBConnection connection)
        {
            Connection = connection;
        }
        public bool AddUser(IPerson person)
        {
            //Here we'll use the saved Connection
            string cmd = @"INSERT persons VALUES(" 
                            + person.UserName + ", "
                            + person.FirstName + ", "
                            + person.LastName + ", "
                            + person.Sex + ", "
                            + person.Title + ", "
                            + person.EMailAdress + ", "
                            + person.Password
                            + ");";

            MySqlCommand command = new MySqlCommand(cmd, Connection.Connection);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                _errorMessage = ex.Message;
                return false;
            }
            return true;
        }
        public bool AddUser(IPerson person, IDBConnection connection) 
        {
            //Here we'll use the given connection
            Connection = connection;
            AddUser(person);
            return true;
        }
        public bool DeleteUser(IPerson person) 
        {
            //Here we'll use the saved Connection
            string cmd = "DELETE FROM persons WHERE id = " + person.ID + ";" ;
            MySqlCommand command = new MySqlCommand(cmd, Connection.Connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                _errorMessage = ex.Message;
                return false;
            }
            return true;
        }
        public bool DeleteUser(IPerson person, IDBConnection connection) 
        {
            //Here we'll use the given connection
            Connection = connection;
            DeleteUser(person);
            return true;
        }
        public bool EditUser(IPerson person)
        {
            string cmd = @"UPDATE persons set username='" 
                            + person.UserName       + "'set first_name='" 
                            + person.FirstName      + "' set last_name='" 
                            + person.LastName       + "' set sex='"
                            + person.Sex            + "' set title='"
                            + person.Title          + "' set email'"
                            + person.EMailAdress    + "' set password='"
                            + person.Password       +
                            " where id='" + person.ID + "';";

            MySqlCommand command = new MySqlCommand(cmd, Connection.Connection);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                _errorMessage = ex.Message;
                return false;
            }
            return true;
        }
        public bool EditUser(IPerson person, IDBConnection connection) 
        {
            //Here we'll use the given connection
            Connection = connection;
            EditUser(person);            
            return true;
        }
    }
}
