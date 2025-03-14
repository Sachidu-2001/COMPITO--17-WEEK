using EsamePolizia.Data;
using EsamePolizia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EsamePolizia.Controllers
{
    public class AnagraficaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AnagraficaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Anagrafiche.ToListAsync());
        }

        [Route("add")]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost("add")]
        public async Task<IActionResult> Add(Anagrafica anagrafica)
        {
            if (ModelState.IsValid)
            {
                _context.Anagrafiche.Add(anagrafica);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(anagrafica);
        }
    }
}

