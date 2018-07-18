using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmNet.Entity;


namespace FarmNet.Respositories
{
    public class R_Create_sensor
    {
        private FarmDB db = new FarmDB();
        public align_sensor_name CreateSensor(string serial_number, string sensor_name, int sensor_type_id)
        {
            if (db.align_sensor_name.Count(c => c.sensor_name == sensor_name) == 0)
            {
                var res = db.align_sensor_name.Add(new align_sensor_name
                {
                    serial_number = serial_number,
                    sensor_name = sensor_name,
                    sensor_type_id = sensor_type_id,
                    status = "ac",
                    create_dt = DateTime.Now
                });
                int save = db.SaveChanges();
                if (save > 0)
                {
                    return res;
                }
                throw new Exception("failed save");
            }
            throw new Exception("have in table");
        }
        public align_sensor_name UpdateSensor(int Id, string sensor_name)
        {
            var res = db.align_sensor_name.FirstOrDefault(c => c.Id == Id);
            res.sensor_name = sensor_name;
            int save = db.SaveChanges();
            if (save > 0)
            {
                return res;
            }
            throw new Exception("failed save");
        }
        public align_sensor_name DeleteSensor(int Id)
        {
            var res = db.align_sensor_name.FirstOrDefault(c => c.Id == Id);
            res.status = "rm";
            int save = db.SaveChanges();
            if (save > 0)
            {
                return res;
            }
            throw new Exception("failed save");
        }

    }
}