using System.Threading.Tasks;
using IsaProject.Controllers;
using IsaProject.Data;
using IsaProject.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace NUnitTest
{
    public class Tests
    {
        public TagsController tagsController;
        private readonly ApplicationDbContext _context;


        #region Unit Test
        [Test]
        public async Task InvalideTagsFormatValide()
        {
            var tag = new Tag(-1, "NewTag", 500);
            tagsController = new TagsController(_context);
            var actionResult = await tagsController.Create(tag);
            Assert.IsInstanceOf<BadRequestObjectResult>(actionResult, typeof(BadRequestObjectResult).ToString());
        }
        #endregion
    }
}