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
        public virtual DbSet<align_sensor_name> align_sensor_name { get; set; }
        public virtual DbSet<images> images { get; set; }
        public virtual DbSet<s_moisture> s_moisture { get; set; }
        public virtual DbSet<s_moisture_level> s_moisture_level { get; set; }
        public virtual DbSet<s_raining> s_raining { get; set; }
        public virtual DbSet<s_temp> s_temp { get; set; }
        public virtual DbSet<s_uv> s_uv { get; set; }
        public virtual DbSet<s_wind> s_wind { get; set; }
        public virtual DbSet<sensor_soil> sensor_soil { get; set; }
        public virtual DbSet<sensor_type> sensor_type { get; set; }
        public virtual DbSet<setting> setting { get; set; }
        public virtual DbSet<status_code> status_code { get; set; }
        public virtual DbSet<user_type> user_type { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<v_User> v_User { get; set; }
    }
}
