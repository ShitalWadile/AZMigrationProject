using AZMigrationPortal.Models;
using AZMigrationPortal.Models.ContextClass;
using AZMigrationPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AZMigrationPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationDetailsController : ControllerBase
    {
        private readonly MigrationContext _context;
        public ApplicationDetailsController (MigrationContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<ApplicationDetails>> AddApp(ApplicationDetails application )
        {
            var add = await _context.AddAsync(application);
            if(application ==null)
            {
                return BadRequest();
            }
            return Ok(add);
        }
    }
}
