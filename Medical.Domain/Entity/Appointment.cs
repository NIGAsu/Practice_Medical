using Medical.Domain.Entity;
using Medical.Domain.Hospitals;

namespace Medical.Domain.Entity
{
    public class Appointment : BaseEntity
    {
        public DateTime? DateTime { get; set; }

        public Doctor? Doctor { get; set; }

        public Patient? Patient { get; set; }

        public Hospital? Hospital { get; set; }
    }
}
