namespace HardwareSensorSystem.Monitoring.Models
{
    /// <summary>
    /// Represents a weekly value range with the link between a sensor and a quantity.
    /// </summary>
    public class ValueWeekly
    {
        /// <summary>
        /// Gets or sets the year for this value.
        /// </summary>
        public short Year { get; set; }

        /// <summary>
        /// Gets or sets the week for this value.
        /// </summary>
        public byte Week { get; set; }

        /// <summary>
        /// Gets or sets the primary key of the sensor that the value belongs to.
        /// </summary>
        public int SensorId { get; set; }

        /// <summary>
        /// Gets or sets the primary key of the quantity that the value belongs to.
        /// </summary>
        public int QuantityId { get; set; }

        /// <summary>
        /// Navigation property for the quantity this value belongs to.
        /// </summary>
        public Quantity Quantity { get; set; }

        /// <summary>
        /// Gets or sets the lowest value.
        /// </summary>
        public float MinValue { get; set; }

        /// <summary>
        /// Gets or sets the highest value.
        /// </summary>
        public float MaxValue { get; set; }
    }
}
