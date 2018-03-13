namespace FarmNet.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("farmnet.Users_online")]
    public partial class Users_online
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int user_id { get; set; }

        [StringLength(50)]
        public string connection_id { get; set; }

        [StringLength(50)]
        public string serial_number { get; set; }

        public DateTime? create_dt { get; set; }
    }
}
