using System;
using System.Linq;
using System.Threading.Tasks;
using IsaProject.Controllers;
using IsaProject.Data;
using IsaProject.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;


namespace NUnitTest
{
    public class UnitTest2
    {
        public TagsController tagsController;
        private ApplicationDbContext _context;
        public long toDeleteId;


        [SetUp]
        public async Task SetUpAsync()
        {
            var dbOption = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(
                    "Server=(localdb)\\mssqllocaldb;Database=aspnet-IsaProject-85C69B8F-B8F8-4606-924A-7A4B90438B74;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;
            _context = new ApplicationDbContext(dbOption);

            tagsController = new TagsController(_context);

            var tag = new Tag("NewTag", 500);

            _context.AddAsync(tag);
            await _context.SaveChangesAsync();

            toDeleteId = _context.Tags.OrderByDescending(p => p.Id).FirstOrDefault().Id;
        }

        #region Unit Test
        [Test]
        public async Task InvalideTagsDelete()
        {
            tagsController = new TagsController(_context);
            Console.WriteLine(toDeleteId);
            await tagsController.DeleteConfirmed(toDeleteId);
            var NullTag = _context.Tags.Find(toDeleteId);
            Assert.IsNull(NullTag);
        }
        #endregion
    }
}
