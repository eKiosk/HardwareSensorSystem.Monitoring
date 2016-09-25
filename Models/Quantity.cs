namespace HardwareSensorSystem.Monitoring.Models
{
    /// <summary>
    /// Represents a physical quantity.
    /// </summary>
    public class Quantity
    {
        /// <summary>
        /// Gets or sets the primary key for the quantity.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name for this quantity.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the SI unit symbol for the quantity.
        /// </summary>
        public string Unit { get; set; }
    }
}
