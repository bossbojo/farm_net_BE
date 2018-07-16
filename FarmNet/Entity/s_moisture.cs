namespace FarmNet.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("farmnet.s_moisture")]
    public partial class s_moisture
    {
        public int Id { get; set; }

        public int? sensor_id { get; set; }

        [Column(TypeName = "money")]
        public decimal? moisture { get; set; }

        public DateTime created_dt { get; set; }
    }
}
