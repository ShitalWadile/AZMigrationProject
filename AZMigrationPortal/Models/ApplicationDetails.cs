using Microsoft.AspNetCore.Hosting.Server;
using System.ComponentModel.DataAnnotations;

namespace AZMigrationPortal.Models
{
    public class ApplicationDetails
    {
        [Key]
        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string AppOwner { get; set; }
        public int BlackoutDuration { get; set; }
        public ServerInformation Server { get; set; }
        public DatabaseInformation Database { get; set; }
        public StorageInformation Storage { get; set; }
        public PortDetails PortDetails { get; set; }
    }

  
}
