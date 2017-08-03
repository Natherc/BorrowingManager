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
    public class TerritoryDataLayer
    {
        public Territory GetById(int id)
        {
            Territory territory = null;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"D:\\Documents\\Visual Studio 2015\\Projects\\BorrowingManager\\BorrowingManager\\borrowingManagerDB.mdf\"; Integrated Security = True";
            con.Open();
            string query = "SELECT * FROM dbo.Territory WHERE id = @Id";
            SqlCommand comm = new SqlCommand(query,con);
            comm.Parameters.Add(new SqlParameter("@Id", id));
            SqlDataReader sdr = comm.ExecuteReader();

            if(sdr.HasRows)
            {
                territory = new Territory();
                sdr.Read();
                territory.Id = (int)sdr["Id"];
                territory.CreationDate = (DateTime)sdr["CreationDate"];
                territory.Locality = (String)sdr["Locality"];
                territory.Number = (String)sdr["Number"];
            }

            con.Close();
            con.Dispose();

            return territory;
        }

        public List<Territory> GetAll()
        {
            List<Territory> territories = new List<Territory>();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"D:\\Documents\\Visual Studio 2015\\Projects\\BorrowingManager\\BorrowingManager\\borrowingManagerDB.mdf\"; Integrated Security = True";
            con.Open();
            string query = "SELECT * FROM dbo.Territory ORDER BY CreationDate asc";
            SqlCommand comm = new SqlCommand(query, con);
            SqlDataReader sdr = comm.ExecuteReader();

            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Territory territory = new Territory();
                    territory.Id = (int)sdr[nameof(territory.Id)];
                    territory.CreationDate = (DateTime)sdr["CreationDate"];
                    territory.Locality = (String)sdr["Locality"];
                    territory.Number = (String)sdr["Number"];
                    territories.Add(territory);
                }
                
            }

            con.Close();
            con.Dispose();

            return territories;
        }

        public int Insert(Territory t)
        {
            int id = 0;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"D:\\Documents\\Visual Studio 2015\\Projects\\BorrowingManager\\BorrowingManager\\borrowingManagerDB.mdf\"; Integrated Security = True";
            con.Open();
            string query = "INSERT INTO dbo.Territory (Number,Locality,CreationDate,PathImage) VALUES (@number,@locality,@CreationDate,@PathImage);SELECT SCOPE_IDENTITY();";
            SqlCommand comm = new SqlCommand(query, con);
         
            comm.Parameters.Add(new SqlParameter("@number", t.Number));
            comm.Parameters.Add(new SqlParameter("@locality", t.Locality));
            comm.Parameters.Add(new SqlParameter("@CreationDate", t.CreationDate));
            comm.Parameters.Add(new SqlParameter("@PathImage", t.PathImage));

            id = Convert.ToInt32(comm.ExecuteScalar());

            con.Close();
            con.Dispose();

            return id;
        }

        public int Update(Territory t)
        {
            int result;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"D:\\Documents\\Visual Studio 2015\\Projects\\BorrowingManager\\BorrowingManager\\borrowingManagerDB.mdf\"; Integrated Security = True";
            con.Open();
            string query = "UPDATE dbo.Territory SET Number=@number,Locality=@locality,CreationDate=@CreationDate WHERE Id = @id;";
            SqlCommand comm = new SqlCommand(query, con);

            comm.Parameters.Add(new SqlParameter("@id", t.Id));
            comm.Parameters.Add(new SqlParameter("@number", t.Number));
            comm.Parameters.Add(new SqlParameter("@locality", t.Locality));
            comm.Parameters.Add(new SqlParameter("@CreationDate", t.CreationDate));

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
            string query = "DELETE FROM dbo.Territory WHERE Id = @id;";
            SqlCommand comm = new SqlCommand(query, con);

            comm.Parameters.Add(new SqlParameter("@id", id));
           
            result = comm.ExecuteNonQuery();

            con.Close();
            con.Dispose();

            return result;
        }
    }
}
