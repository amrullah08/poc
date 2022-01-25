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
    public class SilverArticlesController : Controller
    {
        private readonly SilverContext _context;
        //constructor
        public SilverArticlesController(SilverContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.SilverArticles.ToListAsync());
        }

        public IActionResult AddOrEdit(int SilverArticleId = 0)
        {
            if (SilverArticleId == 0)
                return View(new SilverArticles());
            else
                return View(_context.SilverArticles.Find(SilverArticleId));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("SilverArticleId,TypeofSilverArticle,DateofProcess,Processby,RawSilverQuantity,NetWeight,MakingCharges,Wastage,Total,GST,TotalAmount")] SilverArticles SilverArticles)
        {
            if (ModelState.IsValid)
            {
                if (SilverArticles.SilverArticleId == 0)
                    _context.Add(SilverArticles);
                else
                    _context.Update(SilverArticles);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(SilverArticles);
        }

        public async Task<IActionResult> Delete(int? SilverArticleId)
        {
            var SupCode = await _context.SilverArticles.FindAsync(SilverArticleId);
            _context.SilverArticles.Remove(SupCode);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
