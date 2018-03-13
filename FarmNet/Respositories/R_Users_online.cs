using FarmNet.Entity;
using FarmNet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FarmNet.Respositories
{
    public class R_Users_online
    {
        private FarmDB db = new FarmDB();
        public bool getUserById(int user_id) {
            return db.Users_online.Count(c => c.user_id == user_id)>0?true:false;
        }
        public Users_online UserCreate(m_User_online request)
        {
            var qry = db.Database.SqlQuery<Users_online>("EXEC [farmnet].[s_User_online_create] @user_id,@connection_id,@serial_number",
                new SqlParameter("@user_id", request.user_id),
                new SqlParameter("@connection_id", request.connection_id),
                new SqlParameter("@serial_number", request.serial_number)
            ).FirstOrDefault();
            if (qry != null)
            {
                return qry;
            }
            return null;
        }
        public Users_online UserUpdate(m_User_online request)
        {
            var qry = db.Database.SqlQuery<Users_online>("EXEC [farmnet].[s_User_online_Edit] @user_id,@connection_id,@serial_number",
                new SqlParameter("@user_id", request.user_id),
                new SqlParameter("@connection_id", request.connection_id),
                new SqlParameter("@serial_number", request.serial_number)
            ).FirstOrDefault();
            if (qry != null)
            {
                return qry;
            }
            return null;
        }
        public bool UserRemove(string connection_id)
        {
            var qry = db.Database.ExecuteSqlCommand("EXEC [farmnet].[s_User_online_Remove] @connection_id",
                new SqlParameter("@connection_id", connection_id)
            );
            return qry>0?true:false;
        }
    }
}