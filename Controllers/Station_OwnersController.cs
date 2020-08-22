using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fuela.DBContext;
using Fuela.Models;

namespace Fuela.Controllers
{
    public class Station_OwnersController : Controller
    {
        private readonly ApplicationDBContext _context;

        public Station_OwnersController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: Station_Owners1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Station_owners.ToListAsync());
        }

        // GET: Station_Owners1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var station_Owners = await _context.Station_owners
                .FirstOrDefaultAsync(m => m.ID == id);
            if (station_Owners == null)
            {
                return NotFound();
            }

            return View(station_Owners);
        }

        // GET: Station_Owners1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Station_Owners1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,National_id,Full_Names,Username,Password,Location,Phone,InstallationDate,Role")] Station_Owners station_Owners)
        {
            if (ModelState.IsValid)
            {
                _context.Add(station_Owners);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(station_Owners);
        }

        // GET: Station_Owners1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var station_Owners = await _context.Station_owners.FindAsync(id);
            if (station_Owners == null)
            {
                return NotFound();
            }
            return View(station_Owners);
        }

        // POST: Station_Owners1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,National_id,Full_Names,Username,Password,Location,Phone,InstallationDate,Role")] Station_Owners station_Owners)
        {
            if (id != station_Owners.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(station_Owners);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Station_OwnersExists(station_Owners.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(station_Owners);
        }

        // GET: Station_Owners1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var station_Owners = await _context.Station_owners
                .FirstOrDefaultAsync(m => m.ID == id);
            if (station_Owners == null)
            {
                return NotFound();
            }

            return View(station_Owners);
        }

        // POST: Station_Owners1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var station_Owners = await _context.Station_owners.FindAsync(id);
            _context.Station_owners.Remove(station_Owners);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Station_OwnersExists(int id)
        {
            return _context.Station_owners.Any(e => e.ID == id);
        }
    }
}
