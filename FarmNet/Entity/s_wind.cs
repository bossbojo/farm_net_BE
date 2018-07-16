namespace FarmNet.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("farmnet.s_wind")]
    public partial class s_wind
    {
        public int Id { get; set; }

        public int? sensor_id { get; set; }

        public int? wind { get; set; }

        public DateTime created_dt { get; set; }
    }
}
