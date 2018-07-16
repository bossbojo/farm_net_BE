namespace FarmNet.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("farmnet.s_temp")]
    public partial class s_temp
    {
        public int Id { get; set; }

        public int? sensor_id { get; set; }

        [Column(TypeName = "money")]
        public decimal? temp { get; set; }

        public DateTime created_dt { get; set; }
    }
}
