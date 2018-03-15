namespace FarmNet.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("farmnet.Setting")]
    public partial class Setting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int user_id { get; set; }

        public int? temp { get; set; }

        public int? moisture { get; set; }

        public int? raining { get; set; }

        public int? wind { get; set; }

        public int? uv { get; set; }

        public int? soil { get; set; }

        public int? image { get; set; }

        [Required]
        [StringLength(2)]
        public string status { get; set; }

        public DateTime? update_dt { get; set; }

        public DateTime? create_dt { get; set; }

    }
}
