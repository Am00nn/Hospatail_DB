using Hospital_project.Models;

namespace Hospital_project.Repositories
{
    public interface IBookingRepository
    {
        void BookAppointment(Booking booking); 


        IEnumerable<Booking> ViewAppointmentByClinic(int clinicId); 


        IEnumerable<Booking> ViewAppointmentByPatient(int patientId); 
    }

}