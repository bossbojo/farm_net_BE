using FarmNet.Entity;
using FarmNet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FarmNet.Respositories
{
    public class R_Setting
    {
        private FarmDB db = new FarmDB();
        public setting GetSetting(string serial_number) {
            var user = db.users.FirstOrDefault(c =>c.serial_number == serial_number);
            return db.setting.FirstOrDefault(c => c.user_id == user.user_id);
        }
        public setting SettingEdit(m_Setting request, int user_id)
        {
            var res = db.setting.FirstOrDefault(c => c.user_id == user_id);
            res.sensor = request.sensor;
            res.camera = request.time;
            var save = db.SaveChanges();
            if (save > 0) {
                return res;
            }
            throw new Exception("Failed for save");
        }
    }
}