using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmNet.Entity;
namespace FarmNet.Authen
{
    public class Authentication
    {
        private static string _Token = null;
        private static v_User _User = null;

        public string username { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string status { get; set; }
        public string serial_number { get; set; }
        public long exp { get; set; }

        public static string Token { get { return Authentication._Token; } }

        public static v_User User
        {
            get { return Authentication._User; }
        }

        public static string SetAuthenticated(v_User custObj, int time = 60)
        {
            if (custObj == null)
            {
                Authentication._User = null;
                Authentication._Token = null;
                return null;
            }

            Authentication._Token = Securities.JWTEncode(
            new Authentication
            {
                username = custObj.username,
                firstname = custObj.firstname,
                lastname = custObj.lastname,
                status = custObj.status_name,
                serial_number = custObj.serial_number,
                exp = GetNow.AddMinutes(time).ToBinary()
            });
            Authentication._User = custObj;

            return Authentication._Token;
        }

        public static string SetAuthenticated(string username, string firstname, string lastname, string status,string serial_number, int time = 60)
        {
            if (string.IsNullOrEmpty(username))
            {
                Authentication._User = null;
                Authentication._Token = null;
                return null;
            }

            Authentication._Token = Securities.JWTEncode(
                new Authentication
                {
                    username = username,
                    firstname = firstname,
                    lastname = lastname,
                    status = status,
                    serial_number = serial_number,
                    exp = GetNow.AddMinutes(time).ToBinary()
                });

            return Authentication._Token;
        }

        // Check time of Token if time to the end
        public static bool HasToken(Authentication auth)
        {
            if (auth != null)
                return new DateTime(auth.exp) >= Authentication.GetNow;
            return false;
        }

        // Set Time Zone
        public static DateTime GetNow
        {
            get
            {
                TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
                return TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);
            }
        }
    }
}