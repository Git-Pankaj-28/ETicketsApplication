using ETicketsApplication.Data;
using Microsoft.AspNetCore.Mvc;

namespace ETicketsApplication.Controllers
{
    // 23 creating controller 
    public class ActorsController : Controller
    {
        // to use APPdbContext (in short injecting APPdbContext)
        private readonly AppDbcontext _context; // to use _Context need ctor

        public ActorsController(AppDbcontext context)  
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View(data);
        }
    }
}
