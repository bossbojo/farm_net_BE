using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmNet.Models
{
    public class m_Users
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string serial_number { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }
        public int user_type_id { get; set; }
    }
    public class m_Users_Profile
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string serial_number { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }
    }
    public class m_Users_Password
    {
        public string new_password { get; set; }
        public string old_password { get; set; }
    }
}