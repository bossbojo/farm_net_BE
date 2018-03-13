namespace FarmNet.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("farmnet.Sensor_soil")]
    public partial class Sensor_soil
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string serial_number { get; set; }

        public int? soil_data { get; set; }

        [Required]
        [StringLength(2)]
        public string status { get; set; }

        public DateTime? create_dt { get; set; }

    }
}
