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
        public IEnumerable<align_sensor_name> GetSensorByName(string serial_number)
        {
            return db.align_sensor_name.Where(c => c.serial_number == serial_number && c.status != "rm").ToList();
        }
        public IEnumerable<sensor_type> GetAllTypeSensor()
        {
            return db.sensor_type.ToList();
        }
        public images getImage(int sensor_id)
        {
            return db.images.Where(c => c.sensor_id == sensor_id).OrderByDescending(c => c.create_dt).FirstOrDefault();
        }
        public IEnumerable<s_GetChartBySerial> GetChartBySerial(string serial_number)
        {
            var qry = db.Database.SqlQuery<s_GetChartBySerial>("[farmnet].[s_GetChartBySerial] @serial_number",
                new SqlParameter("@serial_number", serial_number)
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
        public IEnumerable<images> GetImages(int sensor_id)
        {
            return db.images.Where(c => c.sensor_id == sensor_id).OrderByDescending(c => c.create_dt).ToList();
        }
        // get data sensor 
        public IEnumerable<r_s_moisture> GetManyMoisture(string serial_number)
        {
            var allsensor = db.align_sensor_name.Where(c => c.serial_number == serial_number && c.sensor_type_id == 2).ToList();
            List<r_s_moisture> res = new List<r_s_moisture>();
            foreach (var allsensors in allsensor)
            {
                res.Add(new r_s_moisture
                {
                    sensor_name = allsensors.sensor_name,
                    history_sensor = db.s_moisture.Where(c => c.sensor_id == allsensors.Id).ToList()
                });
            }
            return res;
        }
        public IEnumerable<r_s_moisture_level> GetManyMoistureLevel(string serial_number)
        {
            var allsensor = db.align_sensor_name.Where(c => c.serial_number == serial_number && c.sensor_type_id == 3).ToList();
            List<r_s_moisture_level> res = new List<r_s_moisture_level>();
            foreach (var allsensors in allsensor)
            {
                res.Add(new r_s_moisture_level
                {
                    sensor_name = allsensors.sensor_name,
                    history_sensor = db.s_moisture_level.Where(c => c.sensor_id == allsensors.Id).ToList()
                });
            }
            return res;
        }
        public IEnumerable<r_s_raining> GetManyRaining(string serial_number)
        {
            var allsensor = db.align_sensor_name.Where(c => c.serial_number == serial_number && c.sensor_type_id == 4).ToList();
            List<r_s_raining> res = new List<r_s_raining>();
            foreach (var allsensors in allsensor)
            {
                res.Add(new r_s_raining
                {
                    sensor_name = allsensors.sensor_name,
                    history_sensor = db.s_raining.Where(c => c.sensor_id == allsensors.Id).ToList()
                });
            }
            return res;
        }
        public IEnumerable<r_s_temp> GetManyTemp(string serial_number)
        {
            var allsensor = db.align_sensor_name.Where(c => c.serial_number == serial_number && c.sensor_type_id == 5).ToList();
            List<r_s_temp> res = new List<r_s_temp>();
            foreach (var allsensors in allsensor)
            {
                res.Add(new r_s_temp
                {
                    sensor_name = allsensors.sensor_name,
                    history_sensor = db.s_temp.Where(c => c.sensor_id == allsensors.Id).ToList()
                });
            }
            return res;
        }
        public IEnumerable<r_s_uv> GetManyUv(string serial_number)
        {
            var allsensor = db.align_sensor_name.Where(c => c.serial_number == serial_number && c.sensor_type_id == 6).ToList();
            List<r_s_uv> res = new List<r_s_uv>();
            foreach (var allsensors in allsensor)
            {
                res.Add(new r_s_uv
                {
                    sensor_name = allsensors.sensor_name,
                    history_sensor = db.s_uv.Where(c => c.sensor_id == allsensors.Id).ToList()
                });
            }
            return res;
        }
        public IEnumerable<r_s_wind> GetManyWind(string serial_number)
        {
            var allsensor = db.align_sensor_name.Where(c => c.serial_number == serial_number && c.sensor_type_id == 7).ToList();
            List<r_s_wind> res = new List<r_s_wind>();
            foreach (var allsensors in allsensor)
            {
                res.Add(new r_s_wind
                {
                    sensor_name = allsensors.sensor_name,
                    history_sensor = db.s_wind.Where(c => c.sensor_id == allsensors.Id).ToList()
                });
            }
            return res;
        }
        // get new data
        public IEnumerable<s_moisture> GetMoisture(int sensor_id)
        {
            return db.s_moisture.Where(c => c.sensor_id == sensor_id).OrderByDescending(c => c.created_dt).ToList();
        }
        public IEnumerable<s_moisture_level> GetMoisture_level(int sensor_id)
        {
            return db.s_moisture_level.Where(c => c.sensor_id == sensor_id).OrderByDescending(c => c.created_dt).ToList();
        }
        public IEnumerable<s_raining> GetRaining(int sensor_id)
        {
            return db.s_raining.Where(c => c.sensor_id == sensor_id).OrderByDescending(c => c.created_dt).ToList();
        }
        public IEnumerable<s_temp> GetTemp(int sensor_id)
        {
            return db.s_temp.Where(c => c.sensor_id == sensor_id).OrderByDescending(c => c.created_dt).ToList();
        }
        public IEnumerable<s_uv> GetUv(int sensor_id)
        {
            return db.s_uv.Where(c => c.sensor_id == sensor_id).OrderByDescending(c => c.created_dt).ToList();
        }
        public IEnumerable<s_wind> GetWind(int sensor_id)
        {
            return db.s_wind.Where(c => c.sensor_id == sensor_id).OrderByDescending(c => c.created_dt).ToList();
        }
        //  get new data top 1
        public s_moisture GetMoistureSum(int sensor_id)
        {
            return db.s_moisture.Where(c => c.sensor_id == sensor_id).OrderByDescending(c => c.created_dt).FirstOrDefault();
        }
        public s_moisture_level GetMoisture_levelSum(int sensor_id)
        {
            return db.s_moisture_level.Where(c => c.sensor_id == sensor_id).OrderByDescending(c => c.created_dt).FirstOrDefault();
        }
        public s_raining GetRainingSum(int sensor_id)
        {
            return db.s_raining.Where(c => c.sensor_id == sensor_id).OrderByDescending(c => c.created_dt).FirstOrDefault();
        }
        public s_temp GetTempSum(int sensor_id)
        {
            return db.s_temp.Where(c => c.sensor_id == sensor_id).OrderByDescending(c => c.created_dt).FirstOrDefault();
        }
        public s_uv GetUvSum(int sensor_id)
        {
            return db.s_uv.Where(c => c.sensor_id == sensor_id).OrderByDescending(c => c.created_dt).FirstOrDefault();
        }
        public s_wind GetWindSum(int sensor_id)
        {
            return db.s_wind.Where(c => c.sensor_id == sensor_id).OrderByDescending(c => c.created_dt).FirstOrDefault();
        }
    }
}