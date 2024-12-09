using Hospital_project.Models;

namespace Hospital_project.Services
{
    public interface IAppointmentServices
    {
        string AddBooking(string patientName, string clinicName, DateTime bookingDate);
        IEnumerable<Booking> ViewAppointmentByClinic(string clinicName);
        IEnumerable<Booking> ViewAppointmentByPatient(string patientName);
    }
}