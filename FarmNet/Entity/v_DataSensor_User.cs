namespace FarmNet.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("farmnet.v_DataSensor_User")]
    public partial class v_DataSensor_User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int user_id { get; set; }

        [StringLength(50)]
        public string serial_number { get; set; }

        [StringLength(50)]
        public string image { get; set; }

        [Column(TypeName = "money")]
        public decimal? moisture { get; set; }

        public int? moisture_level { get; set; }

        public bool? raining { get; set; }

        [Column(TypeName = "money")]
        public decimal? temp { get; set; }

        public int? uv { get; set; }

        public int? soil_data { get; set; }

        public DateTime? create_dt { get; set; }
    }
}
