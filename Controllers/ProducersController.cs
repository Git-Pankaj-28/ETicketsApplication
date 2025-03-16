using ETicketsApplication.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETicketsApplication.Controllers
{
    // 24 creating Producers controller 
    public class ProducersController : Controller
    {
        private readonly AppDbcontext _context;

        public ProducersController(AppDbcontext context)
        {
            _context = context;

        }
        public async  Task<IActionResult> Index()
        {
            var allProducer = await _context.Producers.ToListAsync();
            return View(allProducer);
        }
    }
}
