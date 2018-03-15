using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmNet.Models
{
    public class s_GetChartBySerial
    {
        public DateTime date { get; set; }
        public string hour { get; set; }
        public int count { get; set; }
        public int moisture_level { get; set; }
        public decimal moisture { get; set; }
        public bool raining { get; set; }
        public decimal? temp { get; set; }
        public int uv { get; set; }
        public int wind { get; set; }
    }
}