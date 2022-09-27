using CLIENT_APP.Data;
using CLIENT_APP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLIENT_APP.Controllers
{
    public class MasterController : Controller
    {
        private readonly ClientContext _context;
        public MasterController(ClientContext context)
        {
            _context = context;
        }
        public async Task<ActionResult> Index()
        {
            var master = await _context.Masters.ToListAsync();
            return View(master);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Master master)
        {
            if(ModelState.IsValid)
            {
                _context.Masters.Add(master);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(master);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || id <= 0)
                return BadRequest();
            var masterinDb = await _context.Masters.FirstOrDefaultAsync(e => e.Id == id);
            if (masterinDb == null)
                return NotFound();

            return View(masterinDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(Master master)
        {
            if (!ModelState.IsValid)
                return View(master);
            _context.Masters.Update(master);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id <= 0)
                return BadRequest();
            var masterinDb = await _context.Masters.FirstOrDefaultAsync(e => e.Id == id);
            if (masterinDb == null)
                return NotFound();
            _context.Masters.Remove(masterinDb);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
