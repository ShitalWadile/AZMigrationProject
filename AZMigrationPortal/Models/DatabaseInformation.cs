using System.ComponentModel.DataAnnotations;

namespace AZMigrationPortal.Models
{
    public class DatabaseInformation
    {
        [Key]
        public int DatabaseId { get; set; }
        public string DatabaseName { get; set; }

        public int ApplicationId { get; set; }
        //public ICollection<ApplicationDetails> Applications { get; set; }


    }
}
