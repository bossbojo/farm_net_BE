namespace FarmNet.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("farmnet.Data_sensor")]
    public partial class Data_sensor
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string serial_number { get; set; }

        [Column(TypeName = "money")]
        public decimal? temp { get; set; }

        [Column(TypeName = "money")]
        public decimal? moisture { get; set; }

        public bool? raining { get; set; }

        public int? moisture_level { get; set; }

        public int? wind { get; set; }

        public int? uv { get; set; }

        [Required]
        [StringLength(2)]
        public string status { get; set; }

        public DateTime? create_dt { get; set; }

    }
}
