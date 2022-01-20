using IsaProject.Controllers;
using IsaProject.Data;
using IsaProject.Models.Entities;
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
    public class UnitTest3
    {
        private ApplicationDbContext _context;
        public CottagesController cottagesController;
        private readonly ICottageService _cottageService;
        private readonly UserManager<AppUser> _userManager;
        public long toDeleteId;

        [SetUp]
        public async Task SetUpAsync()
        {
            var dbOption = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(
                    "Server=(localdb)\\mssqllocaldb;Database=aspnet-IsaProject-85C69B8F-B8F8-4606-924A-7A4B90438B74;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;
            _context = new ApplicationDbContext(dbOption);

            cottagesController = new CottagesController(_context, _cottageService, _userManager);

            var cottage = new Cottage("testCottage", "testAddress", "testCountry", "testCity", "testPromotionalDescription", 3, "NoRules");

            await _context.AddAsync(cottage);

            await _context.SaveChangesAsync();

            toDeleteId = _context.Cottages.OrderByDescending(p => p.Id).FirstOrDefault().Id;
        }

        #region Unit Test
        [Test]
        public async Task CheckLogicalDeleteForCottages()
        {
            cottagesController = new CottagesController(_context, _cottageService, _userManager);
            Console.WriteLine(toDeleteId);
            await cottagesController.DeleteConfirmed(toDeleteId);
            var cottage = _context.Cottages.Find(toDeleteId);
            Assert.AreEqual(true, cottage.IsLogicalDelete);
        }
        #endregion

    }
}
