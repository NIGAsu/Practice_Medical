using Medical.Application.Interfaces;
using Medical.Domain.Entity;
using Medical.Domain.Hospitals;
using Medical.Domain.User;
using Medical.Persistence.EntityTypeContext;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Medical.WebApi.Controllers
{
    public class AddTestController
    {
        private readonly IDbContext _dataBaseContext;

        public AddTestController(DataBaseContext db) => _dataBaseContext = db ?? throw new Exception();

        [HttpGet]
        [Route("AddAppointment")]
        public async Task AddApointment()
        {
            if (_dataBaseContext.Appointments != null)
            {
                Appointment? g = new()
                {
                    DateTime = DateTime.Now,
                    Doctor = new Doctor(),
                    Patient = new Patient(),
                    Hospital = new Hospital()
                };
                _ = await _dataBaseContext.Appointments.AddAsync(g);
                _ = await _dataBaseContext.SaveChangesAsync(new CancellationToken());
            }
        }
        [HttpGet]
        [Route("AddUser")]

        public async Task AddUser([Required] string Login, [Required] string Password)
        {
            if (_dataBaseContext.Users != null)
            {
                User? g = new()
                {
                    Id = 0,
                    Hospital = new Hospital(),
                    Login = Login,
                    Password = Password
                };
                _ = await _dataBaseContext.Users.AddAsync(g);
                _ = await _dataBaseContext.SaveChangesAsync(new CancellationToken());
            }
        }
    }
}
