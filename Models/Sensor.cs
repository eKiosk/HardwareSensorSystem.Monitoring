namespace HardwareSensorSystem.Monitoring.Models
{
    /// <summary>
    /// Represents a sensor.
    /// </summary>
    public class Sensor
    {
        /// <summary>
        /// Gets or sets the primary key for this sensor.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name for this sensor.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the primary key for the sensortype that the sensor belongs to.
        /// </summary>
        public int SensorTypeId { get; set; }

        /// <summary>
        /// Navigation property for the sensortype this sensor belongs to.
        /// </summary>
        public SensorType SensorType { get; set; }

        /// <summary>
        /// Gets or sets the primary key for the terminal that the sensor belongs to.
        /// </summary>
        public int TerminalId { get; set; }

        /// <summary>
        /// Navigation property for the terminal this sensor belongs to.
        /// </summary>
        public Terminal Terminal { get; set; }

        /// <summary>
        /// A random value that change whenever a sensor is inserted or updated.
        /// </summary>
        public byte[] ConcurrencyToken { get; set; }
    }
}
