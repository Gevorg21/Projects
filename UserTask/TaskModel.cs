using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace UserTask
{
    class TaskModel : Model<Task>
    {
        private readonly string _connectionString = @"Data Source=DESKTOP-E7F0CA8\SQLEXPRESS21;initial catalog=UserTaskDB;Integrated Security=True";
        
        public override void Add(Task task)
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

        public override void Update(Task task)
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

        public override void Delete(Task task)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from Tasks where ID=@ID ";
                    command.Parameters.Add(new SqlParameter("@ID", task.ID));
                    command.ExecuteNonQuery();
                }
            }
        }

        public override List<Task> Search(string text)
        {
            List<Task> list = GetAll();
            list = list.Where(x => x.ID.ToString().Contains(text)||x.Description.ToUpper().Contains(text.ToUpper())||x.UserID.ToString().Contains(text)).ToList();
            return list;
            
            /* using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                Task t = new Task();
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select* From Tasks where Concat (ID, Description, UserID) Like @key";
                    command.Parameters.Add(new SqlParameter("@key", $"%{text}%"));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Task task = new Task();
                            task.ID = int.Parse(reader[0].ToString());
                            task.Description = reader[1].ToString();
                            task.UserID = int.Parse(reader[2].ToString());
                            list.Add(task);
                        }
                       // countTask = list.Count();
                        return list;
                    }
                }

            }*/
        }

        public override List<Task> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<Task> list = new List<Task>();
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select* from Tasks";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Task task = new Task();
                            task.ID = int.Parse(reader["ID"].ToString());
                            task.Description = reader["Description"].ToString();
                            task.UserID = int.Parse(reader["UserID"].ToString());
                            list.Add(task);
                        }
                    }
                    return list;
                }
            }
        }

        public bool TestAddTask(string txtUserID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select count(ID)  from Users where ID = @num";
                    command.Parameters.Add(new SqlParameter("@num", txtUserID));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader[0].ToString() == "0")
                                return false;
                        }
                    }
                }
                return true;
            }
        }
    }
}
