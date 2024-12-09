using Hospital_project.Models;

namespace Hospital_project.Repositories
{
    public interface IClinicRepository
    {
        void AddClinic(Clinic c);
        Clinic GetClinicById(int clinicId);
        IEnumerable<Clinic> GetClinics();
        void UpdateClinic(Clinic clinic);
    }
}