using IsaProject.Data;
using IsaProject.Models.Users;
using IsaProject.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest
{
    public class UnitTest8
    {
        public AppointmentService appointmentService;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private ApplicationDbContext _context;

        [SetUp]
        public async Task SetUpAsync()
        {
            var dbOption = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-IsaProject-85C69B8F-B8F8-4606-924A-7A4B90438B74;Trusted_Connection=True;MultipleActiveResultSets=true").Options;
            _context = new ApplicationDbContext(dbOption);
            appointmentService = new AppointmentService(_context, _userManager);

        }

        #region Unit Test
        [Test]
        public async Task IsGetByIdNullAppointment()
        {
            var result = appointmentService.GetById(-1);
            Assert.IsNull(result);
        }
        #endregion
    }
}
