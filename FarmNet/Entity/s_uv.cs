namespace FarmNet.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("farmnet.s_uv")]
    public partial class s_uv
    {
        public int Id { get; set; }

        public int? sensor_id { get; set; }

        public int? uv { get; set; }

        public DateTime created_dt { get; set; }
    }
}
