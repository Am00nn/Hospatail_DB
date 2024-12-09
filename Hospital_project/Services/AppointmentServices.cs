using Hospital_project.Models;
using Hospital_project.Repositories;

namespace Hospital_project.Services
{
    public class AppointmentServices : IAppointmentServices
    {
        private readonly IBookingRepository _bookingRepository;

        private readonly IClinicRepository _clinicRepository;

        private readonly IPatientRepository _patientRepository;

        public AppointmentServices(IBookingRepository bookingRepository, IClinicRepository clinicRepository, IPatientRepository patientRepository)
        {
            _bookingRepository = bookingRepository;

            _clinicRepository = clinicRepository;

            _patientRepository = patientRepository;
        }

        public string AddBooking(string patientName, string clinicName, DateTime bookingDate)
        {

            var patient = _patientRepository.GetPatients()

                .FirstOrDefault(p => p.P_Name.Equals(patientName, StringComparison.OrdinalIgnoreCase));
            if (patient == null)
            {


                return "Patient not found";

            }


            var clinic = _clinicRepository.GetClinics()

              
                .FirstOrDefault(c => c.C_Name.Equals(clinicName, StringComparison.OrdinalIgnoreCase));


            if (clinic == null)

            {
                return "Clinic not found";
            }


            if (clinic.NumberOfSlots > 0)
            {

                clinic.NumberOfSlots -= 1;

                _clinicRepository.UpdateClinic(clinic);


                var booking = new Booking
                {
                    PatientId = patient.P_Id,

                    ClinicId = clinic.CID,

                    BookingDate = bookingDate
                };


                _bookingRepository.BookAppointment(booking);

                return $"Booking successful. Remaining slots: {clinic.NumberOfSlots}";
            }

            return "No available slots in the clinic";
        }

        public IEnumerable<Booking> ViewAppointmentByClinic(string clinicName)
        {
            var clinic = _clinicRepository.GetClinics()

                .FirstOrDefault(c => c.C_Name.Equals(clinicName, StringComparison.OrdinalIgnoreCase));

            if (clinic == null)
            {
                return Enumerable.Empty<Booking>();
            }

            return _bookingRepository.ViewAppointmentByClinic(clinic.CID);
        }

        public IEnumerable<Booking> ViewAppointmentByPatient(string patientName)
        {
            var patient = _patientRepository.GetPatients()

                .FirstOrDefault(p => p.P_Name.Equals(patientName, StringComparison.OrdinalIgnoreCase));

            if (patient == null)
            {
                return Enumerable.Empty<Booking>();
            }

            return _bookingRepository.ViewAppointmentByPatient(patient.P_Id);
        }
    }
}
