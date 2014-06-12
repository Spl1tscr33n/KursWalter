using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurswalter.Core.Interfaces;
using MySql.Data.MySqlClient;

namespace Kurswalter.Core.Persistence
{
    public class ModifyDatabase : IModifyDatabase
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
        public ModifyDatabase() { }
        public ModifyDatabase(IDBConnection connection)
        {
            Connection = connection;
        }
        public bool AddUser(IPerson person)
        {
            //Here we'll use the saved Connection
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
            return true;
        }
        public bool DeleteUser(IPerson person, IDBConnection connection) 
        {
            //Here we'll use the given connection
            Connection = connection;
            DeleteUser(person);
            return true;
        }
        public bool ModifyUser(IPerson person)
        {
            //Here we'll use the saved Connection
            return true;
        }
        public bool ModifyUser(IPerson person, IDBConnection connection) 
        {
            //Here we'll use the given connection
            Connection = connection;
            ModifyUser(person);            
            return true;
        }
    }
}
