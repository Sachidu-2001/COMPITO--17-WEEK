using EsamePolizia.Data;
using EsamePolizia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EsamePolizia.Controllers
{
    public class VerbaleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VerbaleController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Verbali.ToListAsync());
        }

        [Route("add")]
        public IActionResult Add()
        {
            return View();
        }

    }
}
