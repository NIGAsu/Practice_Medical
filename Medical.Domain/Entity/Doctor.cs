namespace Medical.Domain.Entity
{
    public class Doctor : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Speciality { get; set; } = string.Empty;

        public ICollection<Appointment>? Appointments { get; set; }

    }
}
