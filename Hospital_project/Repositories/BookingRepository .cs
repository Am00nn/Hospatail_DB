using Hospital_project.Models;

namespace Hospital_project.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly ApplicationDbContext _context;

        public BookingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void BookAppointment(Booking B)
        {
            _context.Bookings.Add(B);

            _context.SaveChanges();
        }

        public IEnumerable<Booking> ViewAppointmentByClinic(int clinicId)
        {
            return _context.Bookings.Where(b => b.ClinicId == clinicId).ToList();
        }

        public IEnumerable<Booking> ViewAppointmentByPatient(int patientId)
        {

            return _context.Bookings.Where(b => b.PatientId == patientId).ToList();

        }
    }
}
