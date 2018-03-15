using FarmNet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmNet.Models;
using System.Data.SqlClient;

namespace FarmNet.Respositories
{
    public class R_GetData
    {
        private FarmDB db = new FarmDB();
        public IEnumerable<v_DataSensor_User> getDataSensor(string serial_number, int start, int max) {
            return 
                db.v_DataSensor_User
                .Where(c => c.serial_number == serial_number)
                .OrderByDescending(c => c.create_dt)
                .Skip(start).Take(max);
        }
        public IEnumerable<s_GetChartBySerial> GetChartBySerial(string serial_number) {
            var qry = db.Database.SqlQuery<s_GetChartBySerial>("[farmnet].[s_GetChartBySerial] @serial_number",
                new SqlParameter("@serial_number",serial_number)
            ).ToList();
            if (qry != null)
            {
                return qry;
            }
            return null;
        }
        public IEnumerable<s_GetChartBySerialSoil> GetChartBySerialSoil(string serial_number)
        {
            var qry = db.Database.SqlQuery<s_GetChartBySerialSoil>("[farmnet].[s_GetChartBySerialSoil] @serial_number",
                new SqlParameter("@serial_number", serial_number)
            ).ToList();
            if (qry != null)
            {
                return qry;
            }
            return null;
        }
    }
}