using Hospital_project.Models;

namespace Hospital_project.Services
{
    public interface IPatientService
    {
        void AddPatient(Patient patient);
        IEnumerable<Booking> GetPatientAppointments(int patientId);
        IEnumerable<Patient> GetAllPatients();

    }
}