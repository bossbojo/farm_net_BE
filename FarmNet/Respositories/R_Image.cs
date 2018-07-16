using FarmNet.Entity;
using FarmNet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FarmNet.Respositories
{
    public class R_Image
    {
        private FarmDB db = new FarmDB();
        private R_Uploadfile _Uploadfile = new R_Uploadfile();
        public images ImagesCreate(m_Images request)
        {
            var filename = _Uploadfile.uploadImage(request.image);
            var qry = db.Database.SqlQuery<images>("[farmnet].[s_Images_Create] @serial_number,@image",
                new SqlParameter("@serial_number", request.serial_number),
                new SqlParameter("@image", filename)
            ).FirstOrDefault();
            if (qry != null)
            {
                return qry;
            }
            return null;
        }
        public images ImagesEdit(m_Images request,int Id)
        {
            var filename = _Uploadfile.uploadImage(request.image);
            var qry = db.Database.SqlQuery<images>("[farmnet].[s_Images_Edit] @Id,@serial_number,@image",
                new SqlParameter("@Id", Id),
                new SqlParameter("@serial_number", request.serial_number),
                new SqlParameter("@image", filename)
            ).FirstOrDefault();
            if (qry != null)
            {
                return qry;
            }
            return null;
        }
        public images ImagesRemove(int Id)
        {
            var qry = db.Database.SqlQuery<images>("[farmnet].[s_Images_Remove] @Id",
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