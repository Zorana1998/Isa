using Isa.Models;
using IsaProject.Controllers;
using IsaProject.Data;
using IsaProject.Models.Entities;
using IsaProject.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest
{
    public class UnitTest6
    {
        public RatingsController ratingsController;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        [Test]
        public async Task EditRatingIdLessThanZero()
        {
            ratingsController = new RatingsController(_context, _userManager);
            var actionResult = await ratingsController.Edit(-1);
            Assert.IsInstanceOf<NotFoundResult>(actionResult);
        }
    }
}




