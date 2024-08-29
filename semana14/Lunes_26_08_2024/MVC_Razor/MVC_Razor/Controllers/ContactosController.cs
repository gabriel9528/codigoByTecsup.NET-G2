using Microsoft.AspNetCore.Mvc;
using MVC_Razor.Data;
using MVC_Razor.Models;
using System.Diagnostics;

namespace MVC_Razor.Controllers
{
    public class ContactosController : Controller
    {
       private readonly AppDbContext _context;

        public ContactosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Contacto> listContacts= _context.Contactos.ToList();
            return View(listContacts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                contacto.CreationDate = DateTime.Now;
                _context.Contactos.Add(contacto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if(id == null)
            {
                return NotFound();
            }

            Contacto contacto = _context.Contactos.Find(id);
            if(contacto == null)
            {
                return NotFound();
            }

            return View(contacto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                contacto.CreationDate = DateTime.Now;
                _context.Update(contacto);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contacto contacto = _context.Contactos.Find(id);
            if (contacto == null)
            {
                return NotFound();
            }

            return View(contacto);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contacto contacto = _context.Contactos.Find(id);
            if (contacto == null)
            {
                return NotFound();
            }

            return View(contacto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                var contacto1 = _context.Contactos.Find(contacto.Id);
                if(contacto1 == null)
                {
                    return View();
                }
                _context.Contactos.Remove(contacto1);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return View();
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
