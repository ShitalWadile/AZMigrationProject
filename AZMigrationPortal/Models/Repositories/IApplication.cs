namespace AZMigrationPortal.Models.Repositories
{
    public interface IApplication
    {
        //getall
        Task<List<ApplicationDetails>>GetAllAsync();

        //getbyid
        Task<ApplicationDetails> GetByIDApp(int Id);

        //add application
        Task<ApplicationDetails> AddApp(ApplicationDetails application);
        //update application
        Task<ApplicationDetails> UpdateApp(ApplicationDetails application);
        //dalete app
        Task  DeleteApp(int Id);

    }
}
