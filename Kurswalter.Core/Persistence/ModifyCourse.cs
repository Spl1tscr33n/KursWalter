using KursWalter.Core.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWalter.Core.Persistence
{
    class ModifyCourse
    {
        private string _errorMessage = null;
        public IDBConnection Connection { get; set; }
        string ErrorMessage 
        { 
            get
            {
                return _errorMessage;
            }
        }

        bool AddCourse(ICourse course)
        {
            string DatesAndPlaces = null;
            foreach(IDateAndPlace dnp in course.Happenings)
            {
                DatesAndPlaces += dnp.Date.ToString();
                DatesAndPlaces += ";";
                DatesAndPlaces += dnp.Place;
                DatesAndPlaces += ";;\n";
            }
            //Here we'll use the saved Connection
            string cmd = @"INSERT courses VALUES("
                            + course.CourseName     + ", "
                            + DatesAndPlaces        + ", "
                            + course.ShortContent   + ", "
                            + course.LongContent    + ", "
                            + course.Reader         + ", "
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
        bool AddCourse(ICourse course, IDBConnection connection)
        {
            Connection = connection;
            return AddCourse(course);
        }
        bool DeleteCourse(ICourse course)
        {
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
        bool DeleteCourse(ICourse course, IDBConnection connection)
        {
            Connection = connection;
            return AddCourse(course);
        }
        bool EditCourse(ICourse course)
        {
            string DatesAndPlaces = null;
            foreach(IDateAndPlace dnp in course.Happenings)
            {
                DatesAndPlaces += dnp.Date.ToString();
                DatesAndPlaces += ";";
                DatesAndPlaces += dnp.Place;
                DatesAndPlaces += ";;\n";
            }

            string cmd = @"UPDATE courses set username='"
                + course.CourseName     + "' set coursename='"
                + DatesAndPlaces        + "' set last_name='"
                + course.ShortContent   + "' set sex='"
                + course.LongContent    + "' set title='"
                + course.Reader         + "' set email'"    +
                " where id='"           + course.ID         + "';";
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
        bool EditCourse(ICourse course, IDBConnection connection)
        {
            Connection = connection;
            return AddCourse(course);
        }
    }
}
