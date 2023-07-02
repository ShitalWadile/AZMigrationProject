namespace AZMigrationPortal.Models.Repositories
{
    public interface IServerInformation
    {
        Task<List<ServerInformation>> GetAllAsync();
        Task<ServerInformation> GetByIdAsync(int id);
        Task<ServerInformation> AddAsync(ServerInformation server);
        Task<ServerInformation> UpdateAsync(ServerInformation server);
        Task DeleteAsync(int id);
    }
}
