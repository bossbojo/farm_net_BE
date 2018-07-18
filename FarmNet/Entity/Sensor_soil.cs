namespace FarmNet.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("farmnet.sensor_soil")]
    public partial class sensor_soil
    {
        public int Id { get; set; }

        public int? sensor_id { get; set; }

        public int? soil_data { get; set; }

        [Required]
        [StringLength(2)]
        public string status { get; set; }

        public DateTime? create_dt { get; set; }
    }
}
