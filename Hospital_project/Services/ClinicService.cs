using Hospital_project.Models;
using Hospital_project.Repositories;

namespace Hospital_project.Services
{
    public class ClinicService : IClinicService
    {
        private readonly IClinicRepository _clinicRepository;

        public ClinicService(IClinicRepository clinicRepository)
        {
            _clinicRepository = clinicRepository;
        }

        public IEnumerable<Clinic> GetAllClinics()
        {

            return _clinicRepository.GetClinics();

        }

        public void AddClinic(Clinic clinic)
        {

            _clinicRepository.AddClinic(clinic);
        }

    }
}
