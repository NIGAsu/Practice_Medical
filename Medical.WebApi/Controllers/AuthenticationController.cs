using Medical.Application.Interfaces;
using Medical.Domain.User;
using Medical.Persistence.EntityTypeContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;

namespace Medical.WebApi.Controllers
{
    [Route("/api/[Controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IDbContext _dataBaseContext;

        public AuthenticationController(DataBaseContext db) => _dataBaseContext = db ?? throw new Exception();

        [HttpGet]
        [Route("Login")]
        public async Task Login([Required] string Login, [Required] string password)
        {
            if (_dataBaseContext.Users != null)
            {
                User? user = await _dataBaseContext.Users.FirstOrDefaultAsync(u => u.Login == Login && u.Password == password);
                Console.WriteLine($"{user.Id} \n { user.Login }");
            }           
        }
    }
}
