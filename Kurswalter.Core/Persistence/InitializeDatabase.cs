using KursWalter.Core.Interfaces;
using KursWalter.Core.Persistence;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***
 * This class uses a Database which has to be created by the user manually for practical reasons
 * it creates the tables for the course management
***/

namespace KursWalter.Core.Persistence
{
    public class InitializeDatabase
    {
        private string _errorMesage = null;
        private MySqlCommand cmd;

        public string ErrorMessage
        {
            get
            {
                return _errorMesage;
            }
        }

//TODO: Add Fields like in the Interfaces described        
        private readonly string table_persons =
            @"CREATE TABLE persons
                ( 
                    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
                    username        CHAR(20),
                    first_name      CHAR(40),
                    last_name       CHAR(40),
                    sex             CHAR(5),
                    title           CHAR(20),
                    email           TEXT(254),
                    password        CHAR(128),
                    privileges      CHAR(20),
                    courses         CHAR(128),
                    UNIQUE(id),
                    UNIQUE(username)
                );";
        private readonly string table_courses =
            @"CREATE TABLE courses
                ( 
                    id              INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
                    coursename      CHAR(50),
                    room            TEXT(1000),
                    content_short   TEXT(140),
                    content_long    TEXT(1000),
                    reader          CHAR(80),
                    participants    TEXT(10000),
                    UNIQUE(id),
                    UNIQUE(coursename)
                );";
        public IDBConnection Connection { get; set; }
        public InitializeDatabase(IDBConnection connection)
        {
            Connection = connection;
        }

        public bool Init()
        {
            try
            {
                cmd = new MySqlCommand("DROP TABLE IF EXISTS persons;", Connection.Connection);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand("DROP TABLE IF EXISTS courses;", Connection.Connection);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand(table_persons, Connection.Connection);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand(table_courses, Connection.Connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                _errorMesage = ex.Message;
                return false;
            }
            return true;
        }
    }
}
/*http://www.functionx.com/mysqlnet/csharp/Lesson05.htm */
/*create table persons
 *  ( 
 *  ID int constraint aaa primary key,
 *  username char(20) constraint detail unique,
 *  first_name char(40),
 *  last_name char(40),
 *  sex char(5),
 *  title char(20),
 *  email char(254),
 *  password char(128),
    )
 */

/*create table coursees
 *  ( 

 * EDIT:
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    coursename CHAR(50),
    room TEXT(1000),
    content_short TEXT(140),
    content_long TEXT(1000),
    reader CHAR(80),
    UNIQUE(id)
 */