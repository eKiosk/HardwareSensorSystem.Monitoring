namespace HardwareSensorSystem.Monitoring.Models
{
    /// <summary>
    /// Represent a standard time zone.
    /// </summary>
    public class TimeZone
    {
        /// <summary>
        /// Gets or sets the primary key for this time zone.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the standard time name for this time zone.
        /// </summary>
        public string Name { get; set; }
    }
}
