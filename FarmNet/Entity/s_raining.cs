namespace FarmNet.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("farmnet.s_raining")]
    public partial class s_raining
    {
        public int Id { get; set; }

        public int? sensor_id { get; set; }

        public bool? raining { get; set; }

        public DateTime created_dt { get; set; }
    }
}
