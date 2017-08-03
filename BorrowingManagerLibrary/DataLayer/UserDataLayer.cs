using BorrowingManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowingManagerLibrary.DataLayer
{
    public class UserDataLayer : DataLayer
    {
        public User GetById(int id)
        {
            User User = null;

            using (SqlConnection con = GetConnection())
            {
                string query = "SELECT * FROM dbo.[User] WHERE id = @Id";
                SqlCommand comm = new SqlCommand(query, con);
                comm.Parameters.Add(new SqlParameter("@Id", id));
                SqlDataReader sdr = comm.ExecuteReader();

                if (sdr.HasRows)
                {
                    User = new User();
                    sdr.Read();
                    User.Id = (int)sdr["Id"];
                    User.Lastname = (string)sdr["Lastname"];
                    User.Name = (string)sdr["Name"];
                    if (!DBNull.Value.Equals(sdr["Mail"]))
                    {
                        User.Mail = (string)sdr["Mail"];
                    }
                    User.IsDeleted = (bool)sdr["IsDeleted"];

                }

            }

            return User;
        }

        public List<User> GetAll()
        {
            List<User> users = new List<User>();

            using (SqlConnection con = GetConnection())
            {
                string query = "SELECT * FROM dbo.[User] WHERE IsDeleted = 0;";
                SqlCommand comm = new SqlCommand(query, con);
                SqlDataReader sdr = comm.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        User User = new User();
                        User.Id = (int)sdr[nameof(User.Id)];
                        User.Lastname = (string)sdr["Lastname"];
                        User.Name = (string)sdr["Name"];
                        if (!DBNull.Value.Equals(sdr["Mail"]))
                        {
                            User.Mail = (string)sdr["Mail"];
                        }
                        User.IsDeleted = (bool)sdr["IsDeleted"];
                        users.Add(User);
                    }

                }

                
            }
            return users;
        }

        public int Insert(User t)
        {
            int id = 0;

            using (SqlConnection con = GetConnection())
            {
                string query = "INSERT INTO dbo.[User] (Mail,Name,Lastname) VALUES (@Mail,@Name,@Lastname);SELECT SCOPE_IDENTITY();";
                SqlCommand comm = new SqlCommand(query, con);

                comm.Parameters.Add(new SqlParameter("@Mail", t.Mail));
                comm.Parameters.Add(new SqlParameter("@Name", t.Name));
                comm.Parameters.Add(new SqlParameter("@Lastname", t.Lastname));

                id = Convert.ToInt32(comm.ExecuteScalar());

                
            }
            return id;
        }

        public int Update(User u)
        {
            int result;

            using (SqlConnection con = GetConnection())
            {
                string query = "UPDATE dbo.[User] SET Mail=@Mail,Name=@Name,Lastname=@Lastname WHERE Id = @id;";
                SqlCommand comm = new SqlCommand(query, con);

                comm.Parameters.Add(new SqlParameter("@id", u.Id));
                comm.Parameters.Add(new SqlParameter("@Mail", u.Mail));
                comm.Parameters.Add(new SqlParameter("@Name", u.Name));
                comm.Parameters.Add(new SqlParameter("@Lastname", u.Lastname));

                result = comm.ExecuteNonQuery();
                }

            return result;
        }

        public int Delete(int id)
        {
            int result;

            using (SqlConnection con = GetConnection())
            {
                string query = "UPDATE dbo.[User] SET IsDeleted=1 WHERE Id = @id;";
                SqlCommand comm = new SqlCommand(query, con);

                comm.Parameters.Add(new SqlParameter("@id", id));

                result = comm.ExecuteNonQuery();

            }

            return result;
        }
    }
}
