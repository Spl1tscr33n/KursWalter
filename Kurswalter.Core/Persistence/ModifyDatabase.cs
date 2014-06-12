using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurswalter.Core.Interfaces;
using MySql.Data.MySqlClient;

namespace Kurswalter.Core.Persistence
{
    class ModifyDatabase : IModifyDatabase
    {
        public IDBConnection Connection { get; set; }
        public string ErrorMessage { get; }
        public ModifyDatabase() { }
        public ModifyDatabase(IDBConnection connection)
        {
            Connection = connection;
        }
        bool AddUser(IPerson person)
        {
            //Here we'll use the saved Connection
            return true;
        }
        bool AddUser(IPerson person, IDBConnection connection) 
        {
            //Here we'll use the given connection
            Connection = connection;
            AddUser(person);
            return true;
        }
        bool DeleteUser(IPerson person) 
        {
            //Here we'll use the saved Connection
            return true;
        }
        bool DeleteUser(IPerson person, IDBConnection connection) 
        {
            //Here we'll use the given connection
            Connection = connection;
            DeleteUser(person);
            return true;
        }
        bool ModifyUser(IPerson person)
        {
            //Here we'll use the saved Connection
            return true;
        }
        bool ModifyUser(IPerson person, IDBConnection connection) 
        {
            //Here we'll use the given connection
            Connection = connection;
            ModifyUser(person);            
            return true;
        }
    }
}
