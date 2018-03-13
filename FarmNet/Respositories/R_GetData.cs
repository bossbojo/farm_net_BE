using FarmNet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

    }
}