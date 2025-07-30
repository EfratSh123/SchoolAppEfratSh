using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace SchoolAppDAL
{
    public class DataBase
    {
        public SQLiteDataReader ReadFromDbStudents()
        {
            var conn = new SQLiteConnection(@"Data Source=C:\Users\User\אפרת שמואלי\כיתה יד\C#\שיעור 9 Sqlite\SchoolAppEfratSh\Scool.db;");
            conn.Open();
            var command = new SQLiteCommand("SELECT * FROM Students", conn);
            var reader = command.ExecuteReader();
            return reader;
        }

        public SQLiteDataReader ReadFromDbTeachers()
        {
            var conn = new SQLiteConnection(@"Data Source=C:\Users\User\אפרת שמואלי\כיתה יד\C#\שיעור 9 Sqlite\SchoolAppEfratSh\Scool.db;");
            conn.Open();
            var command = new SQLiteCommand("SELECT * FROM Teachers", conn);
            var reader = command.ExecuteReader();
            return reader;
        }
    }
}
