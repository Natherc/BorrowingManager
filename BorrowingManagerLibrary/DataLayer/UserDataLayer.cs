using BorrowingManagerLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowingManagerLibrary.DataLayer
{
    public class UserDataLayer
    {
        public User GetById(int id)
        {
            User User = null;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"D:\\Documents\\Visual Studio 2015\\Projects\\BorrowingManager\\BorrowingManager\\borrowingManagerDB.mdf\"; Integrated Security = True";
            con.Open();
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

            }

            con.Close();
            con.Dispose();

            return User;
        }

        public List<User> GetAll()
        {
            List<User> users = new List<User>();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"D:\\Documents\\Visual Studio 2015\\Projects\\BorrowingManager\\BorrowingManager\\borrowingManagerDB.mdf\"; Integrated Security = True";
            con.Open();
            string query = "SELECT * FROM dbo.[User];";
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
                    if (! DBNull.Value.Equals(sdr["Mail"]))
                        {
                            User.Mail = (string)sdr["Mail"];
                        }
                    users.Add(User);
                }

            }

            con.Close();
            con.Dispose();

            return users;
        }

        public int Insert(User t)
        {
            int id = 0;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"D:\\Documents\\Visual Studio 2015\\Projects\\BorrowingManager\\BorrowingManager\\borrowingManagerDB.mdf\"; Integrated Security = True";
            con.Open();
            string query = "INSERT INTO dbo.[User] (Mail,Name,Lastname) VALUES (@Mail,@Name,@Lastname);SELECT @@IDENTITY;";
            SqlCommand comm = new SqlCommand(query, con);
            SqlParameter outputIdParam = new SqlParameter("@Id", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            comm.Parameters.Add(outputIdParam);
            comm.Parameters.Add(new SqlParameter("@Mail", t.Mail));
            comm.Parameters.Add(new SqlParameter("@Name", t.Name));
            comm.Parameters.Add(new SqlParameter("@Lastname", t.Lastname));

            comm.ExecuteNonQuery();

            id = (int)outputIdParam.Value;

            con.Close();
            con.Dispose();

            return id;
        }

        public int Update(User u)
        {
            int result;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"D:\\Documents\\Visual Studio 2015\\Projects\\BorrowingManager\\BorrowingManager\\borrowingManagerDB.mdf\"; Integrated Security = True";
            con.Open();
            string query = "UPLastname dbo.[User] SET Mail=@Mail,Name=@Name,Lastname=@Lastname WHERE Id = @id;";
            SqlCommand comm = new SqlCommand(query, con);

            comm.Parameters.Add(new SqlParameter("@id", u.Id));
            comm.Parameters.Add(new SqlParameter("@Mail", u.Mail));
            comm.Parameters.Add(new SqlParameter("@Name", u.Name));
            comm.Parameters.Add(new SqlParameter("@Lastname", u.Lastname));

            result = comm.ExecuteNonQuery();



            con.Close();
            con.Dispose();

            return result;
        }

        public int Delete(int id)
        {
            int result;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"D:\\Documents\\Visual Studio 2015\\Projects\\BorrowingManager\\BorrowingManager\\borrowingManagerDB.mdf\"; Integrated Security = True";
            con.Open();
            string query = "DELETE FROM dbo.[User] WHERE Id = @id;";
            SqlCommand comm = new SqlCommand(query, con);

            comm.Parameters.Add(new SqlParameter("@id", id));

            result = comm.ExecuteNonQuery();

            con.Close();
            con.Dispose();

            return result;
        }
    }
}
