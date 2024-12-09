using Hospital_project.Models;

namespace Hospital_project.Repositories
{
    public interface IPatientRepository
    {
        void AddPatient(Patient patient);
        IEnumerable<Patient> GetPatients();
    }
}