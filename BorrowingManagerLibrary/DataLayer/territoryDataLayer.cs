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
    public class TerritoryDataLayer : DataLayer
    {
        public Territory GetById(int id)
        {
            Territory territory = null;

            using (SqlConnection con = GetConnection())
            {


                string query = "SELECT * FROM dbo.Territory WHERE id = @Id";
                SqlCommand comm = new SqlCommand(query, con);
                comm.Parameters.Add(new SqlParameter("@Id", id));
                SqlDataReader sdr = comm.ExecuteReader();

                if (sdr.HasRows)
                {
                    territory = new Territory();
                    sdr.Read();
                    territory.Id = (int)sdr["Id"];
                    territory.CreationDate = (DateTime)sdr["CreationDate"];
                    territory.Locality = (String)sdr["Locality"];
                    territory.Number = (String)sdr["Number"];
                    if (!DBNull.Value.Equals(sdr["PathImage"]))
                    {
                        territory.PathImage = (string)sdr["PathImage"];
                    }
                    territory.IsDeleted = (bool)sdr["IsDeleted"];
                }
            }
            return territory;
        }

        public List<Territory> GetAll()
        {
            List<Territory> territories = new List<Territory>();

            using (SqlConnection con = GetConnection())
            {
                string query = "SELECT * FROM dbo.Territory WHERE IsDeleted = 0 ORDER BY CreationDate asc";
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
                        if (!DBNull.Value.Equals(sdr["PathImage"]))
                        {
                            territory.PathImage = (string)sdr["PathImage"];
                        }
                        territory.IsDeleted = (bool)sdr["IsDeleted"];

                        territories.Add(territory);
                    }

                }

            }

            return territories;
        }

        public int Insert(Territory t)
        {
            int id = 0;
            SqlCommand comm;

            using (SqlConnection con = GetConnection())
            {
                if (String.IsNullOrEmpty(t.PathImage))
                {
                    string query = "INSERT INTO dbo.Territory (Number,Locality) VALUES (@number,@locality);SELECT SCOPE_IDENTITY();";
                    comm = new SqlCommand(query, con);

                    comm.Parameters.Add(new SqlParameter("@number", t.Number));
                    comm.Parameters.Add(new SqlParameter("@locality", t.Locality));
                }
                else
                {
                    string query = "INSERT INTO dbo.Territory (Number,Locality,PathImage) VALUES (@number,@locality,@PathImage);SELECT SCOPE_IDENTITY();";
                    comm = new SqlCommand(query, con);

                    comm.Parameters.Add(new SqlParameter("@number", t.Number));
                    comm.Parameters.Add(new SqlParameter("@locality", t.Locality));
                    comm.Parameters.Add(new SqlParameter("@PathImage", t.PathImage));
                }


                id = Convert.ToInt32(comm.ExecuteScalar());

                
            }
            return id;
        }

        public int Update(Territory t)
        {
            int result;
            SqlCommand comm;

            using (SqlConnection con = GetConnection())
            {

                if (String.IsNullOrEmpty(t.PathImage))
                {
                    string query = "UPDATE dbo.Territory SET Number=@number,Locality=@locality WHERE Id = @id;";
                    comm = new SqlCommand(query, con);

                    comm.Parameters.Add(new SqlParameter("@Id", t.Id));
                    comm.Parameters.Add(new SqlParameter("@number", t.Number));
                    comm.Parameters.Add(new SqlParameter("@locality", t.Locality));
                }
                else
                {
                    string query = "UPDATE dbo.Territory SET Number = @number,Locality = @locality,PathImage = @PathImage WHERE Id = @id; ";
                    comm = new SqlCommand(query, con);

                    comm.Parameters.Add(new SqlParameter("@Id", t.Id));
                    comm.Parameters.Add(new SqlParameter("@number", t.Number));
                    comm.Parameters.Add(new SqlParameter("@locality", t.Locality));
                    comm.Parameters.Add(new SqlParameter("@PathImage", t.PathImage));
                }

                result = comm.ExecuteNonQuery();
            }
            return result;
        }

        public int Delete(int id)
        {
            int result;

            using (SqlConnection con = GetConnection())
            {
                string query = "UPDATE dbo.Territory SET IsDeleted=1 WHERE Id = @id;";
                SqlCommand comm = new SqlCommand(query, con);

                comm.Parameters.Add(new SqlParameter("@id", id));

                result = comm.ExecuteNonQuery();

            }
            return result;
        }
    }
}
