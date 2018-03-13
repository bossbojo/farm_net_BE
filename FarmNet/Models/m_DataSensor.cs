using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmNet.Models
{
    public class m_DataSensor
    {
        public string serial_number { get; set; }
        public decimal temp { get; set; }
        public decimal moisture { get; set; }
        public bool raining { get; set; }
        public int moisture_level { get; set; }
        public int wind { get; set; }
        public int uv { get; set; }
    }
}