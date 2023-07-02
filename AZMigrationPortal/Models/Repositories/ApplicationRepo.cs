using AZMigrationPortal.Models.ContextClass;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace AZMigrationPortal.Models.Repositories
{
    public class ApplicationRepo : IApplication
    {
        private readonly MigrationContext dbContext;

        public ApplicationRepo(MigrationContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<ApplicationDetails>> GetAllAsync()
        {
            return await dbContext.Applications.ToListAsync();
        }

        public async Task<ApplicationDetails> AddApp(ApplicationDetails application)
        {
            try
            {
                var add = dbContext.Applications.Add(application);
                await dbContext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("Failed to add the application details.", ex);
            }
            return application;
        }

        public async Task<ApplicationDetails> GetByIDApp(int ApplicationId)
        {
            try
            {
                ApplicationDetails appDetails = await dbContext.Applications.FindAsync(ApplicationId);
                return appDetails;
            }
            catch(Exception ex)
            {
                throw new Exception($"Failed to retrieve the application details with ID:{ApplicationId}.", ex); ;
            }

        }

        public async Task<ApplicationDetails> UpdateApp(ApplicationDetails application)
        {
            try
            {
                dbContext.Entry(application).State = EntityState.Modified;
                await dbContext.SaveChangesAsync();
                return application;
            }
            catch(Exception ex)
            {
                throw new Exception($"Failed to update the application details with ID: {application.ApplicationId}.", ex);
            }

        }

        public async Task DeleteApp(int Id)
        {
            ApplicationDetails appDetails = dbContext.Applications.Find(Id);
            try
            {
                var delete = dbContext.Applications.Remove(appDetails);  
                await dbContext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception($"Failed to delete the application details with ID: {appDetails.ApplicationId}.", ex);
            }
        }

       
    }
}
