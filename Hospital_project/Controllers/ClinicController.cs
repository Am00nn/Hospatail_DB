using Hospital_project.Models;
using Hospital_project.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClinicController : ControllerBase
    {
        private readonly IClinicService _clinicService;

        public ClinicController(IClinicService clinicService)
        {
            _clinicService = clinicService;
        }

        [HttpGet("GetAllClinics")]
        public IActionResult GetAllClinics()
        {
            var clinics = _clinicService.GetAllClinics();
            return Ok(clinics);
        }

        [HttpPost("AddClinic")]
        public IActionResult AddClinic(
            [FromQuery] string c_Name,

            [FromQuery] string c_Specialization,

            [FromQuery] int numberOfSlots = 20)
        {
          
            var clinic = new Clinic
            {
                C_Name = c_Name,

                C_Specialization = c_Specialization,

                NumberOfSlots = numberOfSlots
            };

           
            _clinicService.AddClinic(clinic);

            return Ok("Clinic added successfully");
        }
    }
}
