namespace FarmNet.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("farmnet.v_User")]
    public partial class v_User
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int user_id { get; set; }

        [StringLength(50)]
        public string serial_number { get; set; }

        [StringLength(50)]
        public string firstname { get; set; }

        [StringLength(50)]
        public string lastname { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string email { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string username { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string password { get; set; }

        public double? lat { get; set; }

        public double? lng { get; set; }

        [StringLength(50)]
        public string status_name { get; set; }

        [StringLength(50)]
        public string user_type { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string status { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool verify { get; set; }

        [StringLength(10)]
        public string house_no { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int user_type_id { get; set; }

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

        [Key]
        [Column(Order = 7)]
        public DateTime time_stamp_ctd { get; set; }
    }
}
