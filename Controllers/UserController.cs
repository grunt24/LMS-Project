using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Roles.Data;
using Roles.Models;

namespace Roles.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            this._context = context;
        }
        public IActionResult Admin()
        {
            var users = _context.Users.ToList();
            List<UserViewModel> userViewModels = users.Select(u => new UserViewModel
            {
                UserName = u.UserName,
                Email = u.Email,

            }).ToList();
            return View(userViewModels);
        }
    }
}
