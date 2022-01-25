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
    public class SupplierDetailsController : Controller
    {
        private readonly SilverContext _context;
        //constructor
        public SupplierDetailsController(SilverContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.SupplierDetails.ToListAsync());
        }

        public IActionResult AddOrEdit(int SupplierCode = 0)
        {
            if (SupplierCode == 0)
                return View(new SupplierDetails());
            else
                return View(_context.SupplierDetails.Find(SupplierCode));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("SupplierCode,SupplierName,SupplierPhoneNo,QuantityBuyed,TotalAmount,AmountPayed,OutstandingAmount")] SupplierDetails SupplierDetails)
        {
            if (ModelState.IsValid)
            {
                if (SupplierDetails.SupplierCode == 0)
                    _context.Add(SupplierDetails);
                else
                    _context.Update(SupplierDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(SupplierDetails);
        }

        public async Task<IActionResult> Delete(int? SupplierCode)
        {
            var SupCode = await _context.SupplierDetails.FindAsync(SupplierCode);
            _context.SupplierDetails.Remove(SupCode);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
