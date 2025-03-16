using ETicketsApplication.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETicketsApplication.Controllers
{
    // 25 add Movies controller same way previos one 
    public class MoviesController : Controller
    {

        private readonly AppDbcontext _context;

        public MoviesController(AppDbcontext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.Include(n =>n.Cinema).ToListAsync(); // including cinema information as we added cinema in view 
            return View(allMovies);
        }
       
    }
}
