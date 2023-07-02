namespace AZMigrationPortal.Models.Repositories
{
    public class ServerRepo : IServerInformation
    {
        public Task<ServerInformation> AddAsync(ServerInformation server)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ServerInformation>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ServerInformation> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServerInformation> UpdateAsync(ServerInformation server)
        {
            throw new NotImplementedException();
        }
    }
}
