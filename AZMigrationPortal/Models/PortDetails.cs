using System.ComponentModel.DataAnnotations;

namespace AZMigrationPortal.Models
{
    public class PortDetails
    {
        [Key]
        public int  PortId { get; set; }
        public Guid PortNumber { get; set; }
        public int ServerId { get; set; }
        public ServerInformation Server { get; set; }
        //public ICollection<ApplicationDetails> Applications { get; set; }
        //public ICollection<ServerInformation> Servers { get; set; }
    }
}
