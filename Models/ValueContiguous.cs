using System;

namespace HardwareSensorSystem.Monitoring.Models
{
    /// <summary>
    /// Represents a value with the link between a sensor and a quantity.
    /// </summary>
    public class ValueContiguous
    {
        /// <summary>
        /// Gets or sets the date for this value.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the time for this value.
        /// </summary>
        public TimeSpan Time { get; set; }

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
        /// Gets or sets the value.
        /// </summary>
        public float Value { get; set; }
    }
}
