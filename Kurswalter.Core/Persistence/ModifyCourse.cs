using Kurswalter.Core.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurswalter.Core.Persistence
{
    class ModifyCourse : IModifyCourse
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

        public bool AddCourse(ICourse course)
        {
            if (Connection == null || Connection.Connection == null)
                throw new ArgumentNullException();
            string DatesAndPlaces = "";
            foreach(IDateAndPlace dnp in course.Happenings)
            {
                DatesAndPlaces += dnp.Date.ToString();
                DatesAndPlaces += ";";
                DatesAndPlaces += dnp.Place;
                DatesAndPlaces += ";;\n";
            }
            string participants = "";
            foreach(IPerson person in course.Participants)
            {
                participants += person.fullName();
                participants += "; ";
            }
            participants += ";;";
            //Here we'll use the saved Connection
            //TODO: Add Fields like in the Interfaces described        
            string cmd = @"INSERT courses VALUES("
                            + course.CourseName     + ", "
                            + DatesAndPlaces        + ", "
                            + course.ShortContent   + ", "
                            + course.LongContent    + ", "
                            + course.Reader         + ", "
                            + participants          + ", "
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
        public bool AddCourse(ICourse course, IDBConnection Connection)
        {
            if (Connection == null || Connection.Connection == null)
                throw new ArgumentNullException();
            this.Connection = Connection;
            return AddCourse(course);
        }
        public bool DeleteCourse(ICourse course)
        {
            if (Connection == null || Connection.Connection == null)
                throw new ArgumentNullException();
            //Here we'll use the saved Connection
            string cmd = "DELETE FROM courses WHERE id = " + course.ID + ";";
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
        public bool DeleteCourse(ICourse course, IDBConnection Connection)
        {
            if (Connection == null || Connection.Connection == null)
                throw new ArgumentNullException();
            this.Connection = Connection;
            return AddCourse(course);
        }
        public bool EditCourse(ICourse course)
        {
            if (Connection == null || Connection.Connection == null)
                throw new ArgumentNullException();
            string DatesAndPlaces = null;
            foreach(IDateAndPlace dnp in course.Happenings)
            {
                DatesAndPlaces += dnp.Date.ToString();
                DatesAndPlaces += ";";
                DatesAndPlaces += dnp.Place;
                DatesAndPlaces += ";;\n";
            }

            string participants = "";
            foreach (IPerson person in course.Participants)
            {
                participants += person.ID.ToString();
                participants += "; ";
            }
            participants += ";;";

            string cmd = @"UPDATE courses set username='"
                + course.CourseName     + "' set coursename='"
                + DatesAndPlaces        + "' set last_name='"
                + course.ShortContent   + "' set sex='"
                + course.LongContent    + "' set title='"
                + course.Reader         + "' set participants='"
                + participants          + " where id='"           
                + course.ID             + "';";
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
        public bool EditCourse(ICourse course, IDBConnection Connection)
        {
            if (Connection == null || Connection.Connection == null)
                throw new ArgumentNullException();
            this.Connection = Connection;
            return AddCourse(course);
        }
    }
}
