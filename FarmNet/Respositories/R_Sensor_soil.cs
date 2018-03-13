using FarmNet.Entity;
using FarmNet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FarmNet.Respositories
{
    public class R_Sensor_soil
    {
        private FarmDB db = new FarmDB();
        public Sensor_soil SensorSoilCreate(m_SensorSoil request)
        {
            var qry = db.Database.SqlQuery<Sensor_soil>("[farmnet].[s_Sensor_soil_Create] @serial_number,@soil_data",
                new SqlParameter("@serial_number", request.serial_number),
                new SqlParameter("@soil_data", request.soil_data)
            ).FirstOrDefault();
            if (qry != null)
            {
                return qry;
            }
            return null;
        }
        public Sensor_soil SensorSoilEdit(m_SensorSoil request,int Id)
        {
            var qry = db.Database.SqlQuery<Sensor_soil>("[farmnet].[s_Sensor_soil_Edit] @Id,@serial_number,@soil_data",
                new SqlParameter("@Id", Id),
                new SqlParameter("@serial_number", request.serial_number),
                new SqlParameter("@soil_data", request.soil_data)
            ).FirstOrDefault();
            if (qry != null)
            {
                return qry;
            }
            return null;
        }
        public Sensor_soil SensorSoilRemove(int Id)
        {
            var qry = db.Database.SqlQuery<Sensor_soil>("[farmnet].[s_Sensor_soil_Remove] @Id",
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