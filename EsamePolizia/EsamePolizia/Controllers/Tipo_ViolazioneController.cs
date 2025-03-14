using EsamePolizia.Data;
using EsamePolizia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EsamePolizia.Controllers
{
    public class Tipo_ViolazioneController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Tipo_ViolazioneController(ApplicationDbContext context)
        {
            _context = context;
        }

 
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tipo_Violazioni.ToListAsync());
        }


        [Route("add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(Tipo_Violazione tipoViolazione)
        {
            if (ModelState.IsValid)
            {
                _context.Tipo_Violazioni.Add(tipoViolazione);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tipoViolazione);
        }
    }
}
