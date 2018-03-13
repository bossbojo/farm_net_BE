namespace FarmNet.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("farmnet.Status_code")]
    public partial class Status_code
    {

        [Key]
        [StringLength(2)]
        public string status { get; set; }

        [StringLength(50)]
        public string status_name { get; set; }
    }
}
