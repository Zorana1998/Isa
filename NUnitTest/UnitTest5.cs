using IsaProject.Controllers;
using IsaProject.Data;
using IsaProject.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest
{
    public class UnitTest5
    {
        public AppealsController appealsController;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;


        #region Unit Test
        [Test]
        public async Task NullForEditAppeals()
        {
            appealsController = new AppealsController(_context, _userManager);
            var actionResult = await appealsController.Edit(null);
            Assert.IsInstanceOf<NotFoundResult>(actionResult);
        }
        #endregion
    }
}
