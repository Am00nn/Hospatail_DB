using Hospital_project.Models;
using Hospital_project.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet("GetAppointmentsByPatient/{patientId}")]
        public IActionResult GetAppointmentsByPatient(int patientId)
        {
            var appointments = _patientService.GetPatientAppointments(patientId);
            return Ok(appointments);
        }

        [HttpPost("AddPatient")]
        public IActionResult AddPatient([FromBody] Patient patient)
        {
            _patientService.AddPatient(patient);
            return Ok("Patient added successfully");
        }
    }
}
