namespace FarmNet.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("farmnet.align_sensor_name")]
    public partial class align_sensor_name
    {
        public int Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(5)]
        public string RunId { get; set; }

        [Required]
        [StringLength(50)]
        public string serial_number { get; set; }

        [Required]
        [StringLength(50)]
        public string sensor_name { get; set; }

        public int sensor_type_id { get; set; }

        [Required]
        [StringLength(2)]
        public string status { get; set; }

        public DateTime create_dt { get; set; }
    }
}
