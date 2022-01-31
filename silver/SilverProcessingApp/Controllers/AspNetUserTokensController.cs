using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SilverProcessingApp.Repository.Models;

namespace SilverProcessingApp.Controllers
{
    public class AspNetUserTokensController : Controller
    {
        private readonly SilverProcessingDbContext _context;

        public AspNetUserTokensController(SilverProcessingDbContext context)
        {
            _context = context;
        }

        // GET: AspNetUserTokens
        public async Task<IActionResult> Index()
        {
            var silverProcessingDbContext = _context.AspNetUserTokens.Include(a => a.User);
            return View(await silverProcessingDbContext.ToListAsync());
        }

        // GET: AspNetUserTokens/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aspNetUserTokens = await _context.AspNetUserTokens
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (aspNetUserTokens == null)
            {
                return NotFound();
            }

            return View(aspNetUserTokens);
        }

        // GET: AspNetUserTokens/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.AspNetUsers, "Id", "Id");
            return View();
        }

        // POST: AspNetUserTokens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,LoginProvider,Name,Value")] AspNetUserTokens aspNetUserTokens)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aspNetUserTokens);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.AspNetUsers, "Id", "Id", aspNetUserTokens.UserId);
            return View(aspNetUserTokens);
        }

        // GET: AspNetUserTokens/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aspNetUserTokens = await _context.AspNetUserTokens.FindAsync(id);
            if (aspNetUserTokens == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.AspNetUsers, "Id", "Id", aspNetUserTokens.UserId);
            return View(aspNetUserTokens);
        }

        // POST: AspNetUserTokens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UserId,LoginProvider,Name,Value")] AspNetUserTokens aspNetUserTokens)
        {
            if (id != aspNetUserTokens.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aspNetUserTokens);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AspNetUserTokensExists(aspNetUserTokens.UserId))
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
            ViewData["UserId"] = new SelectList(_context.AspNetUsers, "Id", "Id", aspNetUserTokens.UserId);
            return View(aspNetUserTokens);
        }

        // GET: AspNetUserTokens/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aspNetUserTokens = await _context.AspNetUserTokens
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (aspNetUserTokens == null)
            {
                return NotFound();
            }

            return View(aspNetUserTokens);
        }

        // POST: AspNetUserTokens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var aspNetUserTokens = await _context.AspNetUserTokens.FindAsync(id);
            _context.AspNetUserTokens.Remove(aspNetUserTokens);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AspNetUserTokensExists(string id)
        {
            return _context.AspNetUserTokens.Any(e => e.UserId == id);
        }
    }
}
