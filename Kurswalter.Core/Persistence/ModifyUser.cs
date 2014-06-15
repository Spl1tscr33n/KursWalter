﻿using System;
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
        public ModifyUser(IDBConnection Connection)
        {
            if (Connection == null || Connection.Connection == null)
                throw new ArgumentNullException();
            this.Connection = Connection;
        }
        public bool AddUser(IPerson person)
        {   
            //Here we'll use the saved Connection
            if (Connection == null || Connection.Connection == null)
                throw new ArgumentNullException();
            string courses = "";
            foreach (ICourse course in person.Courses)
            {
                courses += course.ID.ToString();
                courses += "; ";
            }
            courses += ";;";
            //TODO: Add Fields like in the Interfaces described        
            string cmd = @"INSERT persons VALUES(" 
                            + person.UserName                   + ", "
                            + person.FirstName                  + ", "
                            + person.LastName                   + ", "
                            + person.Sex                        + ", "
                            + person.Title                      + ", "
                            + person.EMailAdress.ToString()     + ", "
                            + person.Password                   + ", "
                            + person.kindOfUser.ToString()      + ", "
                            + person.Courses                    + ", "
                            + ");";


            MySqlCommand command = new MySqlCommand(cmd, Connection.Connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                _errorMessage = ex.Message;
                return false;
            }
            return true;
        }
        public bool AddUser(IPerson person, IDBConnection Connection) 
        {
            if (Connection == null || Connection.Connection == null)
                throw new ArgumentNullException();
            //Here we'll use the given connection
            this.Connection = Connection;
            AddUser(person);
            return true;
        }
        public bool DeleteUser(IPerson person)
        {
            if (Connection == null || Connection.Connection == null)
                throw new ArgumentNullException();
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
        public bool DeleteUser(IPerson person, IDBConnection Connection) 
        {
            if (Connection == null || Connection.Connection == null)
                throw new ArgumentNullException();
            //Here we'll use the given connection
            this.Connection = Connection;
            DeleteUser(person);
            return true;
        }
        public bool EditUser(IPerson person)
        {
            if (Connection == null || Connection.Connection == null)
                throw new ArgumentNullException();
            string courses = "";
            foreach (ICourse course in person.Courses)
            {
                courses += course.ID.ToString();
                courses += "; ";
            }
            courses += ";;";
            string cmd = @"UPDATE persons set username='" 
                            + person.UserName              + "'set first_name='" 
                            + person.FirstName             + "' set last_name='" 
                            + person.LastName              + "' set sex='"
                            + person.Sex                   + "' set title='"
                            + person.Title                 + "' set email'"
                            + person.EMailAdress           + "' set password='"
                            + person.Password              + "' set privileges='"
                            + person.kindOfUser.ToString() + "' set courses='"
                            + person.Courses               + "' where id='"
                            + person.ID + "';";

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
        public bool EditUser(IPerson person, IDBConnection Connection) 
        {
            if (Connection == null || Connection.Connection == null)
                throw new ArgumentNullException();
            //Here we'll use the given connection
            this.Connection = Connection;
            EditUser(person);            
            return true;
        }
    }
}
