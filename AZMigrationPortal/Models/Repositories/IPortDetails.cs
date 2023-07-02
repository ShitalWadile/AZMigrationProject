namespace AZMigrationPortal.Models.Repositories
{
    public interface IPortDetails
    {
        //get all
        Task<List<PortDetails>> GetAllDetails();
        //get by Id
        Task<PortDetails> GetDetailsById(int id);
        //add details

        Task<PortDetails> AddDetails(PortDetails port);
        //update
        Task<PortDetails> UpdateDetails(PortDetails port);
        //delate
        Task DeleteDetails(int id);
    }
}
