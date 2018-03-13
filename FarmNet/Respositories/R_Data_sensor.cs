using FarmNet.Entity;
using FarmNet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FarmNet.Respositories
{
    public class R_Data_sensor
    {
        private FarmDB db = new FarmDB();
        public Data_sensor DataSensorCreate(m_DataSensor request)
        {
            var qry = db.Database.SqlQuery<Data_sensor>("[farmnet].[s_Data_sensor_Create] @serial_number,@temp,@moisture,@raining,@moisture_level,@wind,@uv",
                new SqlParameter("@serial_number", request.serial_number),
                new SqlParameter("@temp", request.temp),
                new SqlParameter("@moisture", request.moisture),
                new SqlParameter("@raining", request.raining),
                new SqlParameter("@moisture_level", request.moisture_level),
                new SqlParameter("@wind", request.wind),
                new SqlParameter("@uv", request.uv)
            ).FirstOrDefault();
            if (qry != null)
            {
                return qry;
            }
            return null;
        }
        public Data_sensor DataSensorEdit(m_DataSensor request,int Id)
        {
            var qry = db.Database.SqlQuery<Data_sensor>("[farmnet].[s_Data_sensor_Edit] @Id,@serial_number,@temp,@moisture,@raining,@moisture_level,@wind,@uv",
                new SqlParameter("@Id", Id),
                new SqlParameter("@serial_number", request.serial_number),
                new SqlParameter("@temp", request.temp),
                new SqlParameter("@moisture", request.moisture),
                new SqlParameter("@raining", request.raining),
                new SqlParameter("@moisture_level", request.moisture_level),
                new SqlParameter("@wind", request.wind),
                new SqlParameter("@uv", request.uv)
            ).FirstOrDefault();
            if (qry != null)
            {
                return qry;
            }
            return null;
        }
        public Data_sensor DataSensorRemove(int Id)
        {
            var qry = db.Database.SqlQuery<Data_sensor>("[farmnet].[s_Data_sensor_Remove] @Id",
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