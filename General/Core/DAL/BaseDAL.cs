using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace General
{
    public class BaseDAL
    {
        private static BaseDAL instance;
        private readonly string connectionString;

        public static BaseDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BaseDAL();
                }
                return instance;
            }
        }

        public BaseDAL()
        {
            connectionString = Configuration.ConnectString;
        }

        public DataTable ExecuteQuery(string storeName, List<MySqlParameter> parameters = null)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storeName;
                if (parameters != null && parameters.Count > 0)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }
                using (MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(cmd))
                {
                    sqlAdapter.Fill(dt);
                }
                conn.Close();
            }
            return dt;
        }
        public DataSet ExecuteQueryDS(string storeName, List<MySqlParameter> parameters = null)
        {
            DataSet dt = new DataSet();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storeName;
                if (parameters != null && parameters.Count > 0)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }
                using (MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(cmd))
                {
                    sqlAdapter.Fill(dt);
                }
                conn.Close();
            }
            return dt;
        }

        public int ExecuteNonQuery(string storeName, ref List<MySqlParameter> outParameters, List<MySqlParameter> parameters = null)
        {
            int result = -1;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storeName;

                //2019/05/31 gnguyen start mod
                if (parameters != null && parameters.Count > 0)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }
                if (outParameters != null && outParameters.Count > 0)
                {
                    cmd.Parameters.AddRange(outParameters.ToArray());
                }
                //2019/05/31 gnguyen end mod
                result = cmd.ExecuteNonQuery();
                conn.Close();
                foreach (var outParam in outParameters)
                {
                    outParam.Value = cmd.Parameters[outParam.ParameterName].Value.ToString();
                }
            }
            return result;
        }

        public int ExecuteNonQuery(string storeName, List<MySqlParameter> parameters = null)
        {
            int result = -1;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storeName;
                if (parameters != null && parameters.Count > 0)
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }
                result = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return result;
        }
    }
}
