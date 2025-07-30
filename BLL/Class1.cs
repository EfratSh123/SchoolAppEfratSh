using Entities1;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolAppDAL;

namespace BLL
{
    public class Functions // Fixed class name casing
    {
        DataBase Database = new DataBase();
        List<Students> StudentsList = new List<Students>();
        List<Teachers> TeachersList = new List<Teachers>();

        public List<Students> LoadStudentsDetails()
        {
            var reader = Database.ReadFromDbStudents();
            while (reader.Read())
            {
                Students student = new Students
                {
                    ID = reader["ID"]?.ToString() ?? string.Empty,
                    FirstName = reader["FirstName"]?.ToString() ?? string.Empty,
                    LastName = reader["LastName"]?.ToString() ?? string.Empty,
                    HomePhone = reader["HomePhone"]?.ToString() ?? string.Empty,
                    BirthdayYear = reader["BirthdayYear"]?.ToString() ?? string.Empty,
                    Class = reader["Class"]?.ToString() ?? string.Empty,
                    Address = reader["Address"]?.ToString() ?? string.Empty
                };
                StudentsList.Add(student);
            }
            reader.Close();
            return StudentsList;
        }
        public List<Teachers> LoadTeachersDetails()
        {
            var reader = Database.ReadFromDbTeachers();
            while (reader.Read())
            {
                Teachers teacher = new Teachers()
                {
                    ID = reader["ID"]?.ToString() ?? string.Empty,
                    FirstName = reader["FirstName"]?.ToString() ?? string.Empty,
                    LastName = reader["LastName"]?.ToString() ?? string.Empty,
                    Phone = reader["Phone"]?.ToString() ?? string.Empty,
                    MailAddress = reader["MailAddress"]?.ToString() ?? string.Empty,
                };
                TeachersList.Add(teacher);
            }
            reader.Close();
            return TeachersList;
        }
    }
}
