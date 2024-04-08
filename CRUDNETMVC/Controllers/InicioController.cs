using CRUDNETMVC.Datos;
using CRUDNETMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CRUDNETMVC.Controllers
{
    public class InicioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InicioController(ApplicationDbContext contexto)
        {
            _context = contexto;    
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Contacto.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
