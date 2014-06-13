using Kurswalter.Core.Interfaces;
using KursWalter.Persistence;
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

namespace Kurswalter.Core.Persistence
{
    public class InitializeDatabase
    {
        private IDBConnection _connection;
        private MySqlCommand cmd;
        private readonly string table_persons =
            @"CREATE TABLE IF NOT EXISTS persons
                ( 
                    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
                    username CHAR(20),
                    first_name CHAR(40),
                    last_name CHAR(40),
                    sex CHAR(5),
                    title CHAR(20),
                    email CHAR(254),
                    password CHAR(128),
                    UNIQUE(id)
                );";
        private readonly string table_courses =
            @"CREATE TABLE IF NOT EXISTS courses
                ( 
                    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
                    coursename CHAR(50),
                    room CHAR(20),
                    time DATETIME,
                    content_short TEXT(140),
                    content_long TEXT(1000),
                    reader CHAR(80),
                    UNIQUE(id)
                );";
        public IDBConnection Connection { get; set; }
        public InitializeDatabase(IDBConnection connection)
        {
            Connection = connection;
        }

        public bool Init()
        {
            cmd = new MySqlCommand(table_persons, Connection.Connection);
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand(table_courses, Connection.Connection);
            cmd.ExecuteNonQuery();
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

/*create table courses
 *  ( 
 *  ID int constraint aab primary key,
 *  coursename char(50) constraint detail unique,
 *  room char(20),
 *  
 *  REMIND THE DATETIME DATABASE ERRORS
 *  C# TIME != DATABASE TIME
 *  1970 vs. 1900 
 *  only 70's kids will understand
 *  http://dev.mysql.com/doc/refman/5.6/en/date-and-time-types.html
 *
 *  time datetime,
 *  content_short char(140),
 *  content_long char(1000),
 *  reader char(80),
 *  translate("reader") = Dozent; 
    )
 */