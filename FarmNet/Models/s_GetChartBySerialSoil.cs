using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmNet.Models
{
    public class s_GetChartBySerialSoil
    {
        public DateTime date { get; set; }
        public string hour { get; set; }
        public int count { get; set; }
        public int soil_data { get; set; }
    }
}