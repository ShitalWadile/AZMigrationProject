namespace AZMigrationPortal.Models.Repositories
{
    public interface IStorageInformation
    {
        Task<List<StorageInformation>> GetAllAsync();
        Task<StorageInformation> GetByIdAsync(int id);
        Task<StorageInformation> AddAsync(StorageInformation storage);
        Task<StorageInformation> UpdateAsync(StorageInformation storage);
        Task DeleteAsync(int id);
    }
}
