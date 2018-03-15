using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmNet.Models
{
    public class m_Setting
    {
        public int temp { get; set; }
    
        public int moisture { get; set; }

        public int raining { get; set; }

        public int wind { get; set; }

        public int uv { get; set; }

        public int soil { get; set; }

        public int image { get; set; }
    }
}