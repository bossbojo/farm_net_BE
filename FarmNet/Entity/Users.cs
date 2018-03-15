namespace FarmNet.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("farmnet.Users")]
    public partial class Users
    {
        [Key]
        public int user_id { get; set; }

        [StringLength(50)]
        public string firstname { get; set; }

        [StringLength(50)]
        public string lastname { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        [StringLength(50)]
        public string serial_number { get; set; }

        public double? lat { get; set; }

        public double? lng { get; set; }

        public bool verify { get; set; }

        [Required]
        [StringLength(2)]
        public string status { get; set; }

        public int user_type_id { get; set; }

        [StringLength(10)]
        public string house_no { get; set; }

        [StringLength(10)]
        public string village_no { get; set; }

        [StringLength(50)]
        public string sub_area { get; set; }

        [StringLength(50)]
        public string area { get; set; }

        [StringLength(50)]
        public string province { get; set; }

        [StringLength(10)]
        public string postal_code { get; set; }

        public DateTime time_stamp_ctd { get; set; }
    }
}
