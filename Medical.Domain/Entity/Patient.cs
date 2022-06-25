using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Domain.Entity
{
    public class Patient:BaseEntity
    {
        public string Name { get; set; } = String.Empty;
        public ICollection<Appointment>? Appointments { get; set; }
    }
}
