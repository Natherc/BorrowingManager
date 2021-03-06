﻿using BorrowingManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowingManagerLibrary.DataLayer
{
    public class UserTerritoryDataLayer : DataLayer
    {
        public UserTerritory GetById(int id)
        {
            UserTerritory userTerritory = null;

            using (SqlConnection con = GetConnection())
            {


                string query = "SELECT * FROM dbo.UserTerritory WHERE id = @Id";
                SqlCommand comm = new SqlCommand(query, con);
                comm.Parameters.Add(new SqlParameter("@Id", id));
                SqlDataReader sdr = comm.ExecuteReader();

                if (sdr.HasRows)
                {
                    userTerritory = new UserTerritory();
                    sdr.Read();
                    userTerritory.Id = (int)sdr["Id"];
                    userTerritory.TerritoryId = (int)sdr["TerritoryId"];
                    userTerritory.UserId = (int)sdr["UserId"];
                    userTerritory.BeginBorrowing = (DateTime)sdr["BeginBorrowing"];
                    if(sdr[nameof(UserTerritory.EndBorrowing)] != DBNull.Value)
                    {
                        userTerritory.EndBorrowing = (DateTime)sdr["EndBorrowing"];
                    }
                    
                    userTerritory.IsDeleted = (bool)sdr["IsDeleted"];
                }
            }
            return userTerritory;
        }

        public List<UserTerritory> GetAll()
        {
            List<UserTerritory> UserTerritories = new List<UserTerritory>();

            using (SqlConnection con = GetConnection())
            {
                string query = "SELECT * FROM dbo.UserTerritory WHERE IsDeleted = 0 ORDER BY TerritoryId asc";
                SqlCommand comm = new SqlCommand(query, con);
                SqlDataReader sdr = comm.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        UserTerritory userTerritory = new UserTerritory();
                        userTerritory.Id = (int)sdr[nameof(userTerritory.Id)];
                        userTerritory.TerritoryId = (int)sdr["TerritoryId"];
                        userTerritory.UserId = (int)sdr["UserId"];
                        if(sdr["EndBorrowing"] != DBNull.Value)
                            userTerritory.EndBorrowing = (DateTime)sdr["EndBorrowing"];
                        userTerritory.BeginBorrowing = (DateTime)sdr["BeginBorrowing"];

                        userTerritory.IsDeleted = (bool)sdr["IsDeleted"];

                        UserTerritories.Add(userTerritory);
                    }

                }

            }

            return UserTerritories;
        }

        public int Insert(UserTerritory t)
        {
            int id = 0;
            SqlCommand comm;

            using (SqlConnection con = GetConnection())
            {

                string query = "INSERT INTO dbo.UserTerritory (TerritoryId,UserId) VALUES (@territoryId,@userId);SELECT SCOPE_IDENTITY();";
                comm = new SqlCommand(query, con);

                comm.Parameters.Add(new SqlParameter("@territoryId", t.TerritoryId));
                comm.Parameters.Add(new SqlParameter("@userId", t.UserId));

                id = Convert.ToInt32(comm.ExecuteScalar());


            }
            return id;
        }

        public int Update(UserTerritory t)
        {
            int result;
            
            

            using (SqlConnection con = GetConnection())
            {
                string query = "UPDATE dbo.UserTerritory SET TerritoryId = @TerritoryId,UserId = @UserId,EndBorrowing=@EndBorrowing WHERE Id = @Id; ";
                List<SqlParameter> list = new List<SqlParameter>();
                list.Add(new SqlParameter("@Id", t.Id));
                list.Add(new SqlParameter("@TerritoryId", t.TerritoryId));
                list.Add(new SqlParameter("@UserId", t.UserId));
                if(t.EndBorrowing == null)
                    list.Add(new SqlParameter("@EndBorrowing", DBNull.Value));
                else
                    list.Add(new SqlParameter("@EndBorrowing", (DateTime)t.EndBorrowing));

                SqlCommand comm = GetSqlCommand(query, con, list.ToArray());
                result = comm.ExecuteNonQuery();
            }
            return result;
        }

        public int Delete(int id)
        {
            int result;

            using (SqlConnection con = GetConnection())
            {
                string query = "UPDATE dbo.UserTerritory SET IsDeleted=1 WHERE Id = @id;";
                SqlCommand comm = new SqlCommand(query, con);

                comm.Parameters.Add(new SqlParameter("@id", id));

                result = comm.ExecuteNonQuery();

            }
            return result;
        }
    }
}
