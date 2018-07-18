namespace FarmNet.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("farmnet.setting")]
    public partial class setting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int user_id { get; set; }

        public int? sensor { get; set; }

        public TimeSpan? camera { get; set; }

        [Required]
        [StringLength(2)]
        public string status { get; set; }

        public DateTime? update_dt { get; set; }

        public DateTime? create_dt { get; set; }
    }
}
