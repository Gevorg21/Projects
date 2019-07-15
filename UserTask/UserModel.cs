using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace UserTask
{
    class UserModel : Model<User>
    {
        private readonly string _connectionString = @"Data Source=DESKTOP-E7F0CA8\SQLEXPRESS21;initial catalog=UserTaskDB;Integrated Security=True";


        
        public override void Add(User user)
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
                    command.CommandText = "insert into Users values(@FullName)";
                    command.Parameters.Add(new SqlParameter("@FullName", user.FullName));
                    command.ExecuteNonQuery();
                }
            }
        }

        public override void Update(User user)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Users set FullName = @FullName where ID = @ID";
                    command.Parameters.Add(new SqlParameter("@FullName", user.FullName));
                    command.Parameters.Add(new SqlParameter("@ID", user.ID));
                    command.ExecuteNonQuery();
                }
            }
        }

        public override void Delete(User user)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from Users where ID=@ID";
                    command.Parameters.Add(new SqlParameter("@ID", user.ID));
                    command.ExecuteNonQuery();
                }
            }
        }

        public override List<User> Search(string text)
        {
            List<User> list = GetAll();
            list = list.Where(x => x.ID.ToString().Contains(text)||x.FullName.ToLower().Contains(text.ToLower())).ToList();
            List<User> mySearchList = new List<User>();
            return list;

            //using (SqlConnection connection = new SqlConnection(_connectionString))
            //{
            //    List<User> list = new List<User>();
            //    connection.Open();
            //    using (SqlCommand command = new SqlCommand())
            //    {
            //        command.Connection = connection;
            //        command.CommandText = "Select* From Users where Concat(ID, FullName) Like @key";
            //        command.Parameters.Add(new SqlParameter("@key", $"%{text}%"));
            //        using (SqlDataReader reader = command.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                User user = new User();
            //                user.ID = int.Parse(reader[0].ToString());
            //                user.FullName = reader[1].ToString();
            //                list.Add(user);
            //            }
            //        }
            //        return list;
            //    }

            //}
        }

        public override List<User> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<User> list = new List<User>();
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select* from Users";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User();
                            user.ID = int.Parse(reader[0].ToString());
                            user.FullName = reader[1].ToString();
                            list.Add(user);

                        }
                    }
                    return list;
                }
            }
        }

        public bool TestRemoveUser(string txtUserID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select count(UserID)from Tasks where UserID = @txtUserID";
                    command.Parameters.Add(new SqlParameter("@txtUserID", txtUserID));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader[0].ToString() == "0")
                                return true;
                        }
                    }
                    return false;
                }
            }
        }

    }
}
