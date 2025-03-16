using ETicketsApplication.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETicketsApplication.Controllers
{
    // 24 add Cinemas controller same way previos one 
    public class CinemasController : Controller
    {
        private readonly AppDbcontext _context;

        public CinemasController(AppDbcontext context)
        {
                _context= context;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _context.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}
