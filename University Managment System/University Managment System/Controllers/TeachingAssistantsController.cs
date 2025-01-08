using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace University_Managment_System.Controllers
{
    public class TeachingAssistantsController : Controller
    {
        private readonly UniContext _context;

        public TeachingAssistantsController(UniContext context)
        {
            _context = context;
        }

        // GET: TeachingAssistants
        public async Task<IActionResult> Index()
        {
            var uniContext = _context.TeachingAssistants.Include(t => t.Department).Include(t => t.Role);
            return View(await uniContext.ToListAsync());
        }

        // GET: TeachingAssistants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teachingAssistant = await _context.TeachingAssistants
                .Include(t => t.Department)
                .Include(t => t.Role)
                .FirstOrDefaultAsync(m => m.TeachingAssistantId == id);
            if (teachingAssistant == null)
            {
                return NotFound();
            }

            return View(teachingAssistant);
        }

        // GET: TeachingAssistants/Create
        public IActionResult Create()
        {
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name");
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "RoleName");
            return View();
        }

        // POST: TeachingAssistants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeachingAssistantId,FirstName,LastName,Email,DepartmentId,PhoneNumber,OfficeHours,RoleDescription,RoleId")] TeachingAssistant teachingAssistant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teachingAssistant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", teachingAssistant.DepartmentId);
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "RoleName", teachingAssistant.RoleId);
            return View(teachingAssistant);
        }

        // GET: TeachingAssistants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teachingAssistant = await _context.TeachingAssistants.FindAsync(id);
            if (teachingAssistant == null)
            {
                return NotFound();
            }
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", teachingAssistant.DepartmentId);
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "RoleName", teachingAssistant.RoleId);
            return View(teachingAssistant);
        }

        // POST: TeachingAssistants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TeachingAssistantId,FirstName,LastName,Email,DepartmentId,PhoneNumber,OfficeHours,RoleDescription,RoleId")] TeachingAssistant teachingAssistant)
        {
            if (id != teachingAssistant.TeachingAssistantId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teachingAssistant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeachingAssistantExists(teachingAssistant.TeachingAssistantId))
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
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", teachingAssistant.DepartmentId);
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "RoleName", teachingAssistant.RoleId);
            return View(teachingAssistant);
        }

        // GET: TeachingAssistants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teachingAssistant = await _context.TeachingAssistants
                .Include(t => t.Department)
                .Include(t => t.Role)
                .FirstOrDefaultAsync(m => m.TeachingAssistantId == id);
            if (teachingAssistant == null)
            {
                return NotFound();
            }

            return View(teachingAssistant);
        }

        // POST: TeachingAssistants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teachingAssistant = await _context.TeachingAssistants.FindAsync(id);
            if (teachingAssistant != null)
            {
                _context.TeachingAssistants.Remove(teachingAssistant);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeachingAssistantExists(int id)
        {
            return _context.TeachingAssistants.Any(e => e.TeachingAssistantId == id);
        }
    }
}
