using Hospital_project.Models;
using Hospital_project.Repositories;

namespace Hospital_project.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;

        private readonly IBookingRepository _bookingRepository;

        public PatientService(IPatientRepository patientRepository, IBookingRepository bookingRepository)
        {
            _patientRepository = patientRepository;


            _bookingRepository = bookingRepository;
        }

        public void AddPatient(Patient patient)
        {

            _patientRepository.AddPatient(patient); 

        }

        public IEnumerable<Booking> GetPatientAppointments(int patientId)
        {
           
            return _bookingRepository.ViewAppointmentByPatient(patientId);
        }
    }

}
