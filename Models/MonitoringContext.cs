using Microsoft.EntityFrameworkCore;

namespace HardwareSensorSystem.Monitoring.Models
{
    /// <summary>
    /// Base class for the Entity Framework database context used for monitoring.
    /// </summary>
    public class MonitoringContext : DbContext
    {
        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}"/> of monitoringsystem.
        /// </summary>
        public DbSet<MonitoringSystem> MonitoringSystems { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}"/> of physical quantity.
        /// </summary>
        public DbSet<Quantity> Quantities { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}"/> of sensors.
        /// </summary>
        public DbSet<Sensor> Sensors { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}"/> of sensortypes.
        /// </summary>
        public DbSet<SensorType> SensorTypes { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}"/> of terminals.
        /// </summary>
        public DbSet<Terminal> Terminals { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}"/> of timezones.
        /// </summary>
        public DbSet<TimeZone> TimeZones { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}"/> of the link between a usergroup and a terminal.
        /// </summary>
        public DbSet<UserGroupTerminal> UserGroupTerminals { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}"/> of actual values.
        /// </summary>
        public DbSet<ValueActual> ValuesActual { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}"/> of contiguous values.
        /// </summary>
        public DbSet<ValueContiguous> ValuesContiguous { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}"/> of daily values.
        /// </summary>
        public DbSet<ValueDaily> ValuesDaily { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}"/> of weekly values.
        /// </summary>
        public DbSet<ValueWeekly> ValuesWeekly { get; set; }

        /// <summary>
        /// Configures the schema needed for the monitoring.
        /// </summary>
        /// <param name="modelBuilder">The modelBuilder being used to construct the model for this context.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Monitoring");

            modelBuilder.Entity<MonitoringSystem>(b =>
            {
                b.ToTable("MonitoringSystems");

                b.Property(ms => ms.Id)
                    .ValueGeneratedOnAdd();
                b.Property(ms => ms.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Quantity>(b =>
            {
                b.ToTable("Quantities");

                b.Property(q => q.Id)
                    .ValueGeneratedOnAdd();
                b.Property(q => q.Name)
                    .IsRequired()
                    .HasMaxLength(50);
                b.Property(q => q.Unit)
                    .IsRequired()
                    .HasMaxLength(16);
            });

            modelBuilder.Entity<Sensor>(b =>
            {
                b.ToTable("Sensors");

                b.Property(s => s.Id)
                    .ValueGeneratedOnAdd();
                b.Property(s => s.Name)
                    .IsRequired()
                    .HasMaxLength(128);
                b.Property(s => s.ConcurrencyToken)
                    .ValueGeneratedOnAddOrUpdate()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<SensorType>(b =>
            {
                b.ToTable("SensorTypes");

                b.Property(st => st.Id)
                    .ValueGeneratedOnAdd();
                b.Property(st => st.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Terminal>(b =>
            {
                b.ToTable("Terminals");

                b.Property(t => t.Id)
                    .ValueGeneratedOnAdd();
                b.Property(t => t.Name)
                    .IsRequired()
                    .HasMaxLength(64);
                b.Property(t => t.Region)
                    .IsRequired()
                    .HasMaxLength(32);
                b.Property(t => t.ConcurrencyToken)
                    .ValueGeneratedOnAddOrUpdate()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TimeZone>(b =>
            {
                b.ToTable("TimeZones");

                b.Property(tz => tz.Id)
                    .ValueGeneratedOnAdd();
                b.Property(tz => tz.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserGroupTerminal>(b =>
            {
                b.ToTable("UserGroups_Terminals");
                b.HasKey(ugt => new { ugt.UserGroupId, ugt.TerminalId });

                b.Property(ugt => ugt.UserGroupId)
                    .ValueGeneratedNever();
                b.Property(ugt => ugt.TerminalId)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ValueActual>(b =>
            {
                b.ToTable("ValuesActual");
                b.HasKey(va => new { va.SensorId, va.QuantityId });

                b.Property(va => va.SensorId)
                    .ValueGeneratedNever();
                b.Property(va => va.QuantityId)
                    .ValueGeneratedNever();
                b.Property(va => va.DateTime)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ValueContiguous>(b =>
            {
                b.ToTable("ValuesContiguous");
                b.HasKey(vc => new { vc.Date, vc.Time, vc.SensorId, vc.QuantityId });

                b.Property(vc => vc.Date)
                    .HasColumnType("date");
                b.Property(vc => vc.SensorId)
                    .ValueGeneratedNever();
                b.Property(vc => vc.QuantityId)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ValueDaily>(b =>
            {
                b.ToTable("ValuesDaily");
                b.HasKey(vd => new { vd.Date, vd.SensorId, vd.QuantityId });

                b.Property(vd => vd.Date)
                    .HasColumnType("date");
                b.Property(vd => vd.SensorId)
                    .ValueGeneratedNever();
                b.Property(vd => vd.QuantityId)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ValueWeekly>(b =>
            {
                b.ToTable("ValuesWeekly");
                b.HasKey(vw => new { vw.Year, vw.Week, vw.SensorId, vw.QuantityId });

                b.Property(vw => vw.SensorId)
                    .ValueGeneratedNever();
                b.Property(vw => vw.QuantityId)
                    .ValueGeneratedNever();
            });
        }
    }
}
