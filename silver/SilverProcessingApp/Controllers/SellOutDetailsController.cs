using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SilverProcessingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilverProcessingApp.Controllers
{
    [Authorize]
    public class SellOutDetailsController : Controller
    {
        private readonly SilverContext _context;
        //constructor
        public SellOutDetailsController(SilverContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.SellOutDetails.ToListAsync());
        }

        public IActionResult AddOrEdit(int SelloutId = 0)
        {
            if (SelloutId == 0)
                return View(new SellOutDetails());
            else
                return View(_context.SellOutDetails.Find(SelloutId));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("SelloutId,BillNo,Soldby,CustomerName,CustomerPhoneNo,Selloutdate,Selloutvalue")] SellOutDetails SellOutDetails)
        {
            if (ModelState.IsValid)
            {
                if (SellOutDetails.SelloutId == 0)
                    _context.Add(SellOutDetails);
                else
                    _context.Update(SellOutDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(SellOutDetails);
        }

        public async Task<IActionResult> Delete(int? SelloutId)
        {
            var SCode = await _context.SellOutDetails.FindAsync(SelloutId);
            _context.SellOutDetails.Remove(SCode);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
