using Medical.Domain.Entity;
using Medical.Persistence;
using Medical.Persistence.EntityTypeContext;
using Microsoft.AspNetCore.Mvc;

namespace Medical.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public ValuesController(DoctorDbContext db)
        {
           
            _ = db.Add(new Doctor()
            {
                Id = 0
            });
            _ = db.SaveChanges();
        }
        [HttpGet]
        public void Values()
        {
        }
    }
}
