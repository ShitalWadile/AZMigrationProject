namespace AZMigrationPortal.Models.Repositories
{
    public class StorageRepo : IStorageInformation
    {
        public Task<StorageInformation> AddAsync(StorageInformation storage)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<StorageInformation>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<StorageInformation> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<StorageInformation> UpdateAsync(StorageInformation storage)
        {
            throw new NotImplementedException();
        }
    }
}
