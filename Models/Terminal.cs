namespace HardwareSensorSystem.Monitoring.Models
{
    /// <summary>
    /// Represents a data terminal.
    /// </summary>
    public class Terminal
    {
        /// <summary>
        /// Gets or sets the primary key for this terminal.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name for this terminal.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a region for this terminal where it is located.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the primary key of the monitoring system that the terminal belongs to.
        /// </summary>
        public int MonitoringSystemId { get; set; }

        /// <summary>
        /// Navigation property for the monitoring system this terminal belongs to.
        /// </summary>
        public MonitoringSystem MonitoringSystem { get; set; }

        /// <summary>
        /// Gets or sets the primary key of the time zone that the terminal belongs to.
        /// </summary>
        public int TimeZoneId { get; set; }

        /// <summary>
        /// Navigation property for the time zone this terminal belongs to.
        /// </summary>
        public TimeZone TimeZone { get; set; }

        /// <summary>
        /// A random value that change whenever a terminal is inserted or updated.
        /// </summary>
        public byte[] ConcurrencyToken { get; set; }
    }
}
