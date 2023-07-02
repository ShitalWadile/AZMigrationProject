namespace AZMigrationPortal.Models.Repositories
{
    public interface ITokenHandler
    {
       Task<string> CreateTokenAsync(User user);
    }
}
