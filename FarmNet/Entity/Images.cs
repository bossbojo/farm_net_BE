namespace FarmNet.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("farmnet.Images")]
    public partial class Images
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string serial_number { get; set; }

        [StringLength(50)]
        public string image { get; set; }

        [Required]
        [StringLength(2)]
        public string status { get; set; }

        public DateTime? create_dt { get; set; }

    }
}
