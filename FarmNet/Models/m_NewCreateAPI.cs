﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmNet.Models
{
    public class m_NewCreateAPI
    {
    }
    public class m_CreateSensor
    {
        public string sensor_name { get; set; }
        public int sensor_type_id { get; set; }
    }
    public class m_UpdateSensor
    {
        public string sensor_name { get; set; }
    }
    public class m_UpdateLatlng
    {
        public string serial_number { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }
    }
    public class m_moisture
    {
        public string sensor_id { get; set; }
        public decimal moisture { get; set; }
    }
    public class m_moisture_level
    {
        public string sensor_id { get; set; }
        public int moisture_level { get; set; }
    }
    public class m_raining
    {
        public string sensor_id { get; set; }
        public int raining { get; set; }
    }
    public class m_temp
    {
        public string sensor_id { get; set; }
        public decimal temp { get; set; }
    }
    public class m_uv
    {
        public string sensor_id { get; set; }
        public decimal uv { get; set; }
    }
    public class m_wind
    {
        public string sensor_id { get; set; }
        public decimal wind { get; set; }
    }
    public class m_soil
    {
        public string sensor_id { get; set; }
        public int soil { get; set; }
    }


}