namespace Medical.Domain.Entity
{
    public class Doctor : BaseEntity
    {
        public string Name { get; set; } = String.Empty;

        public string Speciality { get; set; } = String.Empty;

        public ICollection<Appointment>? Appointments { get; set; } 

    }
}
