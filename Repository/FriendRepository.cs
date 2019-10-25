using General;
using Main.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Repository
{
    public class FriendRepository : BaseDAL
    {
        public DataTable GetFriend(string userId)
        {
            var parameters = new List<MySqlParameter>()
            {
                new MySqlParameter { ParameterName = "@IdUser", MySqlDbType = MySqlDbType.VarChar, Value = userId},

            };
            return ExecuteQuery("usp_GetListFriend", parameters);
        }
        public int AddFriend(FriendModel model, string userId)
        {
            var parameters = new List<MySqlParameter>()
            {
                new MySqlParameter { ParameterName = "@Name", MySqlDbType = MySqlDbType.VarChar, Value = model.Name},
                new MySqlParameter { ParameterName = "@DateOfBirth", MySqlDbType = MySqlDbType.VarChar, Value = model.DateOfBirth},
                new MySqlParameter { ParameterName = "@ImagePath", MySqlDbType = MySqlDbType.LongText, Value = model.ImagePath},
                new MySqlParameter { ParameterName = "@IdUser", MySqlDbType = MySqlDbType.VarChar, Value = userId}
            };
            return ExecuteNonQuery("usp_AddFriend", parameters);
        }
        public int EditFriend(FriendModel model)
        {
            var parameters = new List<MySqlParameter>()
            {
                new MySqlParameter { ParameterName = "@Name", MySqlDbType = MySqlDbType.LongText, Value = model.Name},
                new MySqlParameter { ParameterName = "@DateOfBirth", MySqlDbType = MySqlDbType.VarChar, Value = model.DateOfBirth},
                new MySqlParameter { ParameterName = "@ImagePath", MySqlDbType = MySqlDbType.LongText, Value = model.ImagePath},
                new MySqlParameter { ParameterName = "@Id", MySqlDbType = MySqlDbType.Int32, Value = model.Id}

            };
            return ExecuteNonQuery("usp_EditFriend", parameters);
        }
        public int DelFriend(FriendModel model)
        {
            var parameters = new List<MySqlParameter>()
            {
                new MySqlParameter { ParameterName = "@Id", MySqlDbType = MySqlDbType.Int32, Value = model.Id}
            };
            return ExecuteNonQuery("usp_DelFriend", parameters);
        }
    }
}
