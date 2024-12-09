using Hospital_project.Models;

namespace Hospital_project.Services
{
    public interface IClinicService
    {
        void AddClinic(Clinic clinic);
        IEnumerable<Clinic> GetAllClinics();
    }
}