namespace HardwareSensorSystem.Monitoring.Models
{
    /// <summary>
    /// Represents the link between a usergroup an a terminal.
    /// </summary>
    public class UserGroupTerminal
    {
        /// <summary>
        /// Gets or sets the primary key of the usergroup that is linked to a terminal.
        /// </summary>
        public int UserGroupId { get; set; }

        /// <summary>
        /// Gets or sets the primary key of the terminal that is linked to a usergroup.
        /// </summary>
        public int TerminalId { get; set; }

        /// <summary>
        /// Navigation property of the terminal that is linked to the usergroup.
        /// </summary>
        public Terminal Terminal { get; set; }
    }
}
