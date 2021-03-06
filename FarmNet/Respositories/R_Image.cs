﻿using FarmNet.Entity;
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
        private R_NewRep _Rep = new R_NewRep();
        public images ImagesCreate(m_Images request)
        {
            int id = _Rep.ConvertInt(request.sensor_id);
            var filename = _Uploadfile.uploadImage(request.image);
            var qry = db.Database.SqlQuery<images>("[farmnet].[s_Images_Create] @sensor_id,@image",
                new SqlParameter("@sensor_id", id),
                new SqlParameter("@image", filename)
            ).FirstOrDefault();
            if (qry != null)
            {
                return qry;
            }
            return null;
        }
    }
}