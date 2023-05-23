using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public static class UserDb
    {
        private static string connectionString = "server = localhost; database = TakeAwayProject; integrated security = SSPI";
        private static SqlConnection connection = new SqlConnection(connectionString);

        public static void CreateUser(User newUser)
        {
            string commandString = $"Insert into TWUsers(UserFullName, Username, Password, UserRole) " +
                $"values ('{newUser.Name}', '{newUser.Username}', '{newUser.Password}', {newUser.Role})";

            SqlCommand command = new SqlCommand(commandString, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateUser() { }

        public static void DeleteUser() { }

        public static User GetUser(string username) { return null; }

        public static User GetUser(int id) { return null; }

        public static DataTable GetUsers() { return null; }
    }
}
