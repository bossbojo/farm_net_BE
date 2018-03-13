using FarmNet.Entity;
using FarmNet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace FarmNet.Respositories
{
    public class R_Users
    {
        private FarmDB db = new FarmDB();
        public v_User GetUsers(int user_id) {
            return db.v_User.Where(c => c.user_id == user_id).FirstOrDefault();
        }
        public bool Checkpassword(string password) {
            password = Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
            return db.Users.Count(c => c.password == password)>0? true:false;
        }
        public Users UserCreate(m_Users request)
        {
            request.password = Convert.ToBase64String(Encoding.UTF8.GetBytes(request.password));
            var qry = db.Database.SqlQuery<Users>("EXEC [farmnet].[s_Users_Create] @firstname,@lastname,@email,@username,@password,@serial_number,@lat,@lng,@user_type_id",
                new SqlParameter("@firstname", request.firstname),
                new SqlParameter("@lastname", request.lastname),
                new SqlParameter("@email", request.email),
                new SqlParameter("@username", request.username),
                new SqlParameter("@password", request.password),
                new SqlParameter("@serial_number", request.serial_number),
                new SqlParameter("@lat", request.lat),
                new SqlParameter("@lng", request.lng),
                new SqlParameter("@user_type_id", request.user_type_id)
            ).FirstOrDefault();
            if (qry != null) {
                return qry;
            }
            return null;
        }
        public Users UserEdit(m_Users request,int Id)
        {
            var qry = db.Database.SqlQuery<Users>("EXEC [farmnet].[s_Users_Edit] @Id,@firstname,@lastname,@email,@username,@password,@serial_number,@lat,@lng,@user_type_id",
                new SqlParameter("@Id",Id),
                new SqlParameter("@firstname", request.firstname),
                new SqlParameter("@lastname", request.lastname),
                new SqlParameter("@email", request.email),
                new SqlParameter("@username", request.username),
                new SqlParameter("@password", request.password),
                new SqlParameter("@serial_number", request.serial_number),
                new SqlParameter("@lat", request.lat),
                new SqlParameter("@lng", request.lng),
                new SqlParameter("@user_type_id", request.user_type_id)
            ).FirstOrDefault();
            if (qry != null)
            {
                return qry;
            }
            return null;
        }
        public Users UserEditProfile(m_Users_Profile request, int Id)
        {
            var qry = db.Database.SqlQuery<Users>("EXEC [farmnet].[s_Users_Edit_Profile] @Id,@firstname,@lastname,@email,@serial_number,@lat,@lng",
                new SqlParameter("@Id", Id),
                new SqlParameter("@firstname", request.firstname),
                new SqlParameter("@lastname", request.lastname),
                new SqlParameter("@email", request.email),
                new SqlParameter("@serial_number", request.serial_number),
                new SqlParameter("@lat", request.lat),
                new SqlParameter("@lng", request.lng)
            ).FirstOrDefault();
            if (qry != null)
            {
                return qry;
            }
            return null;
        }
        public Users UserEditPassword(m_Users_Password request, int Id)
        {
            request.new_password = Convert.ToBase64String(Encoding.UTF8.GetBytes(request.new_password));
            var qry = db.Database.SqlQuery<Users>("EXEC [farmnet].[s_Users_Edit_Password] @Id,@password",
                new SqlParameter("@Id", Id),
                new SqlParameter("@password", request.new_password)
            ).FirstOrDefault();
            if (qry != null)
            {
                return qry;
            }
            return null;
        }
        public Users UserRemove(int Id)
        {
            var qry = db.Database.SqlQuery<Users>("EXEC [farmnet].[s_Users_Remove] @Id",
                new SqlParameter("@Id", Id)
            ).FirstOrDefault();
            if (qry != null)
            {
                return qry;
            }
            return null;
        }
    }
}