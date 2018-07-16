using FarmNet.Entity;
using FarmNet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FarmNet.Respositories
{
    public class R_Setting
    {
        private FarmDB db = new FarmDB();

        public setting SettingEdit(m_Setting request, int user_id)
        {
            var qry = db.Database.SqlQuery<setting>("[farmnet].[s_Setting_Edit] @user_id,@image,@moisture,@raining,@temp,@soil,@uv,@wind",
                new SqlParameter("@user_id", user_id),
                new SqlParameter("@image", request.image),
                new SqlParameter("@moisture", request.moisture),
                new SqlParameter("@raining", request.raining),
                new SqlParameter("@temp", request.temp),
                new SqlParameter("@soil", request.soil),
                new SqlParameter("@uv", request.uv),
                new SqlParameter("@wind", request.wind)
            ).FirstOrDefault();
            if (qry != null)
            {
                return qry;
            }
            return null;
        }
        public setting SettingRemove(int user_id)
        {
            var qry = db.Database.SqlQuery<setting>("[farmnet].[s_Setting_Remove] @user_id",
                new SqlParameter("@user_id", user_id)
            ).FirstOrDefault();
            if (qry != null)
            {
                return qry;
            }
            return null;
        }
    }
}