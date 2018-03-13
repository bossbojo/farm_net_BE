namespace FarmNet.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FarmDB : DbContext
    {
        public FarmDB()
            : base("name=FarmDB")
        {
        }

        public virtual DbSet<Data_sensor> Data_sensor { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<Sensor_soil> Sensor_soil { get; set; }
        public virtual DbSet<Status_code> Status_code { get; set; }
        public virtual DbSet<User_type> User_type { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<v_DataSensor_User> v_DataSensor_User { get; set; }
        public virtual DbSet<v_User> v_User { get; set; }
        public virtual DbSet<Users_online> Users_online { get; set; }
    }
}
