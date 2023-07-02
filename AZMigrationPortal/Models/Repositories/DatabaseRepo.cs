namespace AZMigrationPortal.Models.Repositories
{
    public class DatabaseRepo : IDatabaseInformation
    {
        public Task<DatabaseInformation> AddDB(DatabaseInformation database)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDB(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DatabaseInformation>> GetAllData()
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseInformation> GetDataByID(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseInformation> UpdateDB(DatabaseInformation database)
        {
            throw new NotImplementedException();
        }
    }
}
