using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace AZMigrationPortal.Models
{
    public class ServerInformation
    {
        [Key]
        public int ServerId { get; set; }
        public int ApplicationId { get; set; }
        public int PortNumber { get; set; }
        public int IpAddress { get; set; }
        public string ServerName { get; set; }
      //public PortDetails PortId { get; set; }
        //public ICollection<ApplicationDetails> Applications { get; set; }
        //public ICollection<PortDetails> Ports { get; set; }




    }
}
