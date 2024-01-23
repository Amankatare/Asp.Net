using ChatWithMe.DataAccess.Data;
using ChatWithMe.Entities.Entities;
using ChatWithMe.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChatWithMe.MVC.Controllers
{
    public class MessageController : Controller
    {
        private readonly SignalContext _context;
        private readonly UserManager<AppUser> _userManager;
        public MessageController(SignalContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            ViewBag.CurrentUserName = currentUser.UserName;

            // Retrieve messages for the current user
            var messages = await _context.Messages.ToListAsync();

            return View(messages);
        }

        public async Task<IActionResult> Create(Message message)
        {
            if (ModelState.IsValid)
            {
                message.UserName = User.Identity.Name;
                var sender = _userManager.GetUserAsync(User);
                message.UserId = sender.Id;
                await _context.Messages.AddAsync(message);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return Ok();
        }
    }
}
