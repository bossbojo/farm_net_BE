using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmNet.Entity;
using System.Text;

namespace FarmNet.Respositories
{
    public class R_Authentication
    {
        private FarmDB db = new FarmDB();
        public bool checkHaveUser(string username)
        {
            var res = db.users.Count(c => c.username == username);
            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkHaveSerialNumber(string serial_number)
        {
            var res = db.users.Count(c => c.serial_number == serial_number);
            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkActive(string username) {
            var res = db.users.FirstOrDefault(c => c.username == username);
            if (res.status == "ac")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public v_User Auth(string username, string password) {
            var pass = Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
            var user = db.users.FirstOrDefault(c => c.username == username && c.password == pass);
            if (user != null)
            {
                return db.v_User.FirstOrDefault(c => c.username == username);
            }
            else {
                return null;
            }
        }
    }
}