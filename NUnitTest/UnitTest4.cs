using IsaProject.Controllers;
using IsaProject.Data;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest
{
    
    public class UnitTest4
    {
        public TagsController tagsController;
        private readonly ApplicationDbContext _context;

        [Test]
        public void TestCreateView()
        {
            var controller = new TagsController(_context);
            var result = controller.Create() as ViewResult;
            NUnit.Framework.Assert.AreEqual(null, result.ViewName);

        }
    }
}
