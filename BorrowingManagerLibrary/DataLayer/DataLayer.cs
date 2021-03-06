﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowingManagerLibrary.DataLayer
{
    public class DataLayer : IDisposable
    {
        public string ConnectionString = ConfigurationManager.ConnectionStrings["connectionStringDb"].ConnectionString;
        private SqlConnection _con;

        public void Dispose()
        {
            if(_con != null)
            {
                _con.Close();
                _con.Dispose();
            }
        }

        public SqlConnection GetConnection()
        {
            if(_con == null)
            {
                _con = new SqlConnection();
                
            }
            _con.ConnectionString = ConnectionString;
            if (_con.State == System.Data.ConnectionState.Broken || 
                _con.State == System.Data.ConnectionState.Closed)
            {
                _con.Open();
            }
                

            return _con;
        }

        public SqlDataReader GetSqlDataReader(string query, SqlConnection con, params SqlParameter[] parameters)
        {
            SqlCommand comm = GetSqlCommand(query, con,parameters);
            
            SqlDataReader sdr = comm.ExecuteReader();

            return sdr;
        }

        public SqlCommand GetSqlCommand(string query, SqlConnection con, params SqlParameter[] parameters)
        {
            SqlCommand comm = new SqlCommand(query, con);
            if (parameters != null && parameters.Length > 0)
            {
                foreach (SqlParameter param in parameters)
                {
                    comm.Parameters.Add(param);
                }
            }

            
            return comm;
        }
    }
}
