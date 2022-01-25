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
    public class EmployeeDetailsController : Controller
    {
        private readonly SilverContext _context;
        //constructor
        public EmployeeDetailsController(SilverContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.EmployeeDetails.ToListAsync());
        }

        public IActionResult AddOrEdit(int EmployeeId = 0)
        {
            if (EmployeeId == 0)
                return View(new EmployeeDetails());
            else
                return View(_context.EmployeeDetails.Find(EmployeeId));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("EmployeeId,EmployeeName,JobType,Salary")] EmployeeDetails EmployeeDetails)
        {
            if (ModelState.IsValid)
            {
                if (EmployeeDetails.EmployeeId == 0)
                    _context.Add(EmployeeDetails);
                else
                    _context.Update(EmployeeDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(EmployeeDetails);
        }

        public async Task<IActionResult> Delete(int? EmployeeId)
        {
            var EmpId = await _context.EmployeeDetails.FindAsync(EmployeeId);
            _context.EmployeeDetails.Remove(EmpId);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
