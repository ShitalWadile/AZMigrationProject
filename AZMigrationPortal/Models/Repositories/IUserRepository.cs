namespace AZMigrationPortal.Models.Repositories
{
    public interface IUserRepository
    {
        Task<User> AuthenticateAsync(string username, string password); 
    }
}
