using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp_ClinicalManagement.Data;
using WebApp_ClinicalManagement.Models;

namespace WebApp_ClinicalManagement.Controllers
{
    public class AppointmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AppointmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Appointments
        public async Task<IActionResult> Index()
        {
              return _context.StockMovements != null ? 
                          View(await _context.StockMovements.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.StockMovements'  is null.");
        }

        // GET: Get Appointment Done
        public IActionResult IndexAvailable()
        {
            if (_context.Items != null)
            {
                var availableItems = _context.Items
                    .Where(item => item.IsDone == false)
                    .ToList();

                return View("Index", availableItems);


            }
            else
            {
                return Problem("Entity set 'ApplicationDbContext.Items'  is null.");
            }
        }

        // GET: Get Discontinued Items
        public IActionResult IndexIsDone()
        {
            if (_context.Items != null)
            {
                var discontinuedItems = _context.Items
                    .Where(item => item.IsDone == true)
                    .ToList();

                return View("Index", discontinuedItems);

            }
            else
            {
                return Problem("Entity set 'ApplicationDbContext.Items'  is null.");
            }
        }

        // GET: Appointments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StockMovements == null)
            {
                return NotFound();
            }

            var appointment = await _context.StockMovements
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }

        // GET: Appointments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Appointments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,Observation,IsDone")] Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appointment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appointment);
        }

        // GET: Appointments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StockMovements == null)
            {
                return NotFound();
            }

            var appointment = await _context.StockMovements.FindAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }
            return View(appointment);
        }

        // POST: Appointments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,Observation,IsDone")] Appointment appointment)
        {
            if (id != appointment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appointment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppointmentExists(appointment.Id))
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
            return View(appointment);
        }

        // GET: Appointments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StockMovements == null)
            {
                return NotFound();
            }

            var appointment = await _context.StockMovements
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }

        // POST: Appointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StockMovements == null)
            {
                return Problem("Entity set 'ApplicationDbContext.StockMovements'  is null.");
            }
            var appointment = await _context.StockMovements.FindAsync(id);
            if (appointment != null)
            {
                _context.StockMovements.Remove(appointment);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppointmentExists(int id)
        {
          return (_context.StockMovements?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
