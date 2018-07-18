using FarmNet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmNet.Models
{
    public class r_s_moisture
    {
        public string sensor_name { get; set; }
        public List<s_moisture> history_sensor { get; set; }
    }
    public class r_s_moisture_level
    {
        public string sensor_name { get; set; }
        public List<s_moisture_level> history_sensor { get; set; }
    }
    public class r_s_raining
    {
        public string sensor_name { get; set; }
        public List<s_raining> history_sensor { get; set; }
    }
    public class r_s_temp
    {
        public string sensor_name { get; set; }
        public List<s_temp> history_sensor { get; set; }
    }
    public class r_s_uv
    {
        public string sensor_name { get; set; }
        public List<s_uv> history_sensor { get; set; }
    }
    public class r_s_wind
    {
        public string sensor_name { get; set; }
        public List<s_wind> history_sensor { get; set; }
    }
    public class r_sensor_soil
    {
        public string sensor_name { get; set; }
        public List<sensor_soil> history_sensor { get; set; }
    }
}