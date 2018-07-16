﻿using FarmNet.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FarmNet.Respositories
{
    public class R_NewRep
    {
        private FarmDB db = new FarmDB();
        public users Update_latlng(string serial_number, float lat, float lng)
        {
            var qry = db.Database.SqlQuery<users>("[farmnet].[s_Users_Edit_latlng] @serial_number,@lat,@lng",
                new SqlParameter("@serial_number", serial_number),
                new SqlParameter("@lat", lat),
                new SqlParameter("@lng", lng)
            ).FirstOrDefault();
            return qry;
        }
        public s_moisture Create_Moisture(int sensor_id, decimal moisture)
        {
            var add = db.s_moisture.Add(new s_moisture {
                sensor_id = sensor_id,
                moisture = moisture
            });
            int res = db.SaveChanges();
            if (res > 0) {
                return add;
            }
            throw new Exception("failed for save");
        }
        public s_moisture_level Create_MoistureLevel(int sensor_id, int moisture_level)
        {
            var add = db.s_moisture_level.Add(new s_moisture_level {
                sensor_id = sensor_id,
                moisture_level = moisture_level
            });
            int res = db.SaveChanges();
            if (res > 0) {
                return add;
            }
            throw new Exception("failed for save");
        }
        public s_raining Create_Raining(int sensor_id, bool raining)
        {
            var add = db.s_raining.Add(new s_raining {
                sensor_id = sensor_id,
                raining = raining
            });
            int res = db.SaveChanges();
            if (res > 0)
            {
                return add;
            }
            throw new Exception("failed for save");
        }
        public s_temp Create_Temp(int sensor_id, decimal temp)
        {
            var add = db.s_temp.Add(new s_temp
            {
                sensor_id = sensor_id,
                temp = temp
            });
            int res = db.SaveChanges();
            if (res > 0)
            {
                return add;
            }
            throw new Exception("failed for save");
        }
        public s_uv Create_Uv(int sensor_id, int uv)
        {
            var add = db.s_uv.Add(new s_uv
            {
                sensor_id = sensor_id,
                uv = uv
            });
            int res = db.SaveChanges();
            if (res > 0)
            {
                return add;
            }
            throw new Exception("failed for save");
        }
        public s_wind Create_Wind(int sensor_id, int wind)
        {
            var add = db.s_wind.Add(new s_wind
            {
                sensor_id = sensor_id,
                wind = wind
            });
            int res = db.SaveChanges();
            if (res > 0)
            {
                return add;
            }
            throw new Exception("failed for save");
        }

    }
}