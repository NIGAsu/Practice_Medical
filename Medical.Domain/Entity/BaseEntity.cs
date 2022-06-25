using System.ComponentModel.DataAnnotations;

namespace Medical.Domain.Entity
{
    abstract public class BaseEntity
    {
        [Key]
        virtual public int Id { get; set; }
    }
}
