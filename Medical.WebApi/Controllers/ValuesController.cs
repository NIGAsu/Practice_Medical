using Medical.Domain.Entity;
using Medical.Persistence.EntityTypeContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Medical.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DbContext _dataBaseContext;

        public ValuesController(DataBaseContext db) => _dataBaseContext = db;


        [HttpGet]
        public void Values()
        {
            _ = _dataBaseContext.Add(new Doctor()
            {
                Id = 0
            });
            _ = _dataBaseContext.SaveChanges();
        }
    }
}
