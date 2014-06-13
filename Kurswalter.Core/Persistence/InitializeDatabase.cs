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
        private MySqlCommand cmd = new MySqlCommand(table_persons, _connection);
        private readonly string table_persons =
           @"CREATE TABLE persons
                ( 
                   ID int constraint aaa primary key,
                   username char(20) constraint detail unique,
                   first_name char(40),
                   last_name char(40),
                   sex char(5),
                   title char(20),
                   email char(254),
                   password char(128),
                );";
        private readonly string table_courses =
            @"CREATE TABLE courses
                ( 
                   ID int constraint aab primary key,
                   coursename char(50) constraint detail unique,
                   room char(20),
                   time datetime,
                   content_short char(140),
                   content_long char(1000),
                   reader char(80),
                );";
        public IDBConnection Connection { get; set; }
        public InitializeDatabase(IDBConnection connection)
        {
            Connection = connection;
        }
        
    }
}
/*http://www.functionx.com/mysqlnet/csharp/Lesson05.htm*/
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