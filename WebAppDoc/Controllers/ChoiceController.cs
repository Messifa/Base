using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppDoc.Data;
using WebAppDoc.Models;

namespace WebAppDoc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChoiceController : ControllerBase
    {

        private readonly DbContextDoc _dbContextDoc;
        public ChoiceController(DbContextDoc dbContextDoc)
        {
            _dbContextDoc = dbContextDoc;
        }
        [HttpPost("Choix")]
        public async Task<IActionResult> Choix(Choice choicer)
        {
            // Effectuez les opérations de validation et d'enregistrement du rendez-vous dans la base de données
            Choice choice = new Choice
            {
                DateTime = choicer.DateTime,
                Description = choicer.Description
                // Ajoutez d'autres propriétés du rendez-vous si nécessaire
            };

            _dbContextDoc.Choices.Add(choice);
            await _dbContextDoc.SaveChangesAsync();

            return Ok("choice created successfully!");
        }
    }
}
