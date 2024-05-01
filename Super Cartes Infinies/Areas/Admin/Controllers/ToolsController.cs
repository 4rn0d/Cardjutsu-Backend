using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Super_Cartes_Infinies.Data;

namespace Super_Cartes_Infinies.Areas.Admin
{
    [Area("Admin")]
    public class ToolsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ToolsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Tools
        public async Task<IActionResult> Index()
        {
            List<string> result = (await _context.Database.GetPendingMigrationsAsync()).ToList();
            this.ViewData["PendingMigrations"] = result;

            return View();
        }

        [HttpGet]
        public IActionResult ApplyMigrations()
        {
            _context.Database.Migrate();

            return RedirectToAction(nameof(Index));
        }
    }
}
