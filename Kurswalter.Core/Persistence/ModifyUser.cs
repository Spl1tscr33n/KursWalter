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
                   /* username char(20) constraint detail unique,
                   first_name char(40),
                   last_name char(40),
                   sex char(5),
                   title char(20),
                   email char(254),
                   password char(128),*/
            string cmd = @"INSERT persons VALUES(" 
                            + person.UserName + ", "
                            + person.FirstName + ", "
                            + person.LastName + ", "
                            + person.Sex + ", "
                            + person.Title + ", "
                            + person.EMailAdress + ", "
                            + person.Password
                            + ");";
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
            string cmd = "DELETE FROM persons WHERE username = " + person.ID + ";" ;
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
            //Here we'll use the saved Connection
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
