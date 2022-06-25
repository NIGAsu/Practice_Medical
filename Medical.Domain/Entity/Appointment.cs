namespace Medical.Domain.Entity
{
    public class Appointment : BaseEntity
    {
        public DateTime? DateTime { get; set; }

        public Doctor? Doctor { get; set; }
        public Patient? Patient { get; set; }
    }
}
