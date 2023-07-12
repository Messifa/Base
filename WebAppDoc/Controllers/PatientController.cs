using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppDoc.Data;
using WebAppDoc.Models;

namespace WebAppDoc.Controllers
{
    [Route("api/Patient")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        // [HttpGet]
        // [Route("GetPatient")]

        private readonly DbContextDoc _dbContextDoc;
        public PatientController(DbContextDoc dbContextDoc)
        {
            _dbContextDoc = dbContextDoc;
        }

       // [HttpGet]
       // [Route("get-patient-by-id/[Id]")]
      //  public async Task<IActionResult> GetAsync()
      //  {
           //  var patient = await _dbContextDoc.Patients.ToListAsync();
           //   return Ok(patient);
            
       // }

        [HttpPost]
        [Route("create-patient")]
        public async Task<IActionResult> Register(patient patient)
        {
            _dbContextDoc.Patients.Add(patient);
            await _dbContextDoc.SaveChangesAsync();
            return Created($"/get-patient-by-id/{patient.Id}", patient);
        }

        [HttpPost]
        [Route("Login-patient")]
        public IActionResult Login(patient patient)
        {
            // Effectuez les opérations de validation de connexion de l'utilisateur
            var existingUser = _dbContextDoc.Patients.FirstOrDefault(patient => patient.name == patient.name && patient.password == patient.password);
            if (existingUser == null)
            {
                return BadRequest("Invalid username or password");
            }

            // Générez un jeton d'authentification JWT si nécessaire

            return Ok("Login successful!");
        }

        //[HttpDelete]
        // [Route("Id")]
        //public async Task<IActionResult> DeleteAsync(int Id)
        // {
        // var patientToDelete = await _dbContextDoc.Patients.FindAsync(Id);
        // if (patientToDelete != null)
        // {
        //    return NotFound();
        // }
        //  _dbContextDoc.Patients.Remove(patientToDelete);
        //  await _dbContextDoc.SaveChangesAsync();
        //  return NoContent();
        //  }

    }
}
