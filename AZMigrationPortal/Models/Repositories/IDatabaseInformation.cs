namespace AZMigrationPortal.Models.Repositories
{
    public interface IDatabaseInformation
    {
        //for get all
        Task<List<DatabaseInformation>> GetAllData();
        //get by id
        Task<DatabaseInformation> GetDataByID(int Id);
        //add database info
        Task<DatabaseInformation> AddDB(DatabaseInformation database);

        //update DB
        Task<DatabaseInformation> UpdateDB(DatabaseInformation database);

        //delete DB
        Task DeleteDB(int Id);

        
    }
}
