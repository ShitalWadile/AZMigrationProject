namespace AZMigrationPortal.Models.Repositories
{
    public class StaticUserRepository : IUserRepository
    {
        private List<User> Users = new List<User>()
        {
            new User()
            {
                EmailId="readonly@user.com",
                UserId=Guid.NewGuid(),
                UserName="readonly@user.com",
                Password="readonly@01",
                Roles=new List<string> {"reader"}
            },

            new User()
            {
                EmailId="readwrite@user.com",
                UserId=Guid.NewGuid(),
                UserName="readwrite@user.com",
                Password="readwrite@01",
                Roles=new List<string> {"reader,writer"}
            }

        };

        public List<User> Users1 { get => Users; set => Users = value; }

        public async Task<User> AuthenticateAsync(string username, string password)
        {
            var user = Users1.Find(x => x.UserName.Equals(username, StringComparison.InvariantCultureIgnoreCase) &&
             x.Password == password);
            //if(user !=null)
            //{
            //    return user;        
            //}
            return user;
        }
    }
}
