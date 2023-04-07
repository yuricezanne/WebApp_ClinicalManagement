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
    public class ProfessionalTeamsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProfessionalTeamsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProfessionalTeams
        public async Task<IActionResult> Index()
        {
              return _context.ProfessionalTeam != null ? 
                          View(await _context.ProfessionalTeam.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.ProfessionalTeam'  is null.");
        }

        // GET: ProfessionalTeams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProfessionalTeam == null)
            {
                return NotFound();
            }

            var professionalTeam = await _context.ProfessionalTeam
                .FirstOrDefaultAsync(m => m.Id == id);
            if (professionalTeam == null)
            {
                return NotFound();
            }

            return View(professionalTeam);
        }

        // GET: ProfessionalTeams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProfessionalTeams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,DateOfBirth,Address,ZipCode,City,Country,Vat,JobId,JobRole")] ProfessionalTeam professionalTeam)
        {
            if (ModelState.IsValid)
            {
                _context.Add(professionalTeam);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(professionalTeam);
        }

        // GET: ProfessionalTeams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProfessionalTeam == null)
            {
                return NotFound();
            }

            var professionalTeam = await _context.ProfessionalTeam.FindAsync(id);
            if (professionalTeam == null)
            {
                return NotFound();
            }
            return View(professionalTeam);
        }

        // POST: ProfessionalTeams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,DateOfBirth,Address,ZipCode,City,Country,Vat,JobId,JobRole")] ProfessionalTeam professionalTeam)
        {
            if (id != professionalTeam.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(professionalTeam);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfessionalTeamExists(professionalTeam.Id))
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
            return View(professionalTeam);
        }

        // GET: ProfessionalTeams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProfessionalTeam == null)
            {
                return NotFound();
            }

            var professionalTeam = await _context.ProfessionalTeam
                .FirstOrDefaultAsync(m => m.Id == id);
            if (professionalTeam == null)
            {
                return NotFound();
            }

            return View(professionalTeam);
        }

        // POST: ProfessionalTeams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProfessionalTeam == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ProfessionalTeam'  is null.");
            }
            var professionalTeam = await _context.ProfessionalTeam.FindAsync(id);
            if (professionalTeam != null)
            {
                _context.ProfessionalTeam.Remove(professionalTeam);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfessionalTeamExists(int id)
        {
          return (_context.ProfessionalTeam?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
