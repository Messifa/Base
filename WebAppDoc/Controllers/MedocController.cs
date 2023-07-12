using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppDoc.Data;
using WebAppDoc.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppDoc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedocController : ControllerBase
    {
        private readonly DbContextDoc _dbContextDoc;
        public  MedocController(DbContextDoc dbContextDoc)
        {
            _dbContextDoc = dbContextDoc;
        }

        
         [HttpGet("{userId}")]
         [Route("get-user-by-id/[userId]")]
         public async Task<string> GetAsync(int userid)
         {
            var medoc = await _dbContextDoc.medocs.FindAsync();

           return Ok(medoc);
         }

       
        
         [HttpDelete]
         [Route("get-user-by-id/[userId]")]
         public async Task<IActionResult> DeleteAsync(int Id)
        {
           var userToDelete = await _dbContextDoc.medocs.FindAsync(Id);
           if (userToDelete != null)
           {
             return NotFound();
           }
           _dbContextDoc.medocs.Remove(userToDelete);
           await _dbContextDoc.SaveChangesAsync();
           return NoContent();
         }
        
    }
}

