using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace UserTask
{
    class TaskModelChild
    {
        private readonly string _connectionString = @"Data Source=DESKTOP-E7F0CA8\SQLEXPRESS21;initial catalog=UserTaskDB;Integrated Security=True";

        public void AddTaskChild(Task task)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into Tasks values (@Description,@UserID )";

                    command.Parameters.Add(new SqlParameter("@Description", task.Description));
                    command.Parameters.Add(new SqlParameter("@UserID", task.UserID));
                    command.ExecuteNonQuery();
                }

            }
        }

        public void UpdateTaskChilde(Task task)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Tasks set Description = @Description,UserID = @UserID  where(ID = @ID )";
                    command.Parameters.Add(new SqlParameter("@Description", task.Description));
                    command.Parameters.Add(new SqlParameter("@UserID", task.UserID));
                    command.Parameters.Add(new SqlParameter("@ID", task.ID));
                    command.ExecuteNonQuery();
                }
            }
        }

       
    }
}