using System.ComponentModel.DataAnnotations;

namespace AZMigrationPortal.Models
{
    public class StorageInformation
    {
        [Key]
        public int StorageId { get; set; }  
        public string StorageName { get; set; }
        public string StorageType { get; set; }
        public int ApplicationId { get; set; }
        //public ICollection<ApplicationDetails> Applications { get; set; }

    }
}
