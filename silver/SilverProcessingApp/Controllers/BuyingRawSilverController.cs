using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SilverProcessingApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SilverProcessingApp.Controllers
{
    [Authorize]
    public class BuyingRawSilverController : Controller
    {
        private readonly SilverContext _context;
        //constructor
        private readonly IWebHostEnvironment _hostEnvironment;
        public BuyingRawSilverController(SilverContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.BuyingRawSilver.ToListAsync());
        }

        public IActionResult AddOrEdit(int SilverCode = 0)
        {
            if (SilverCode == 0)
                return View(new BuyingRawSilver());
            else
                return View(_context.BuyingRawSilver.Find(SilverCode));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("SilverCode,RawSilverQuantity,NoSilverUnits,GramsPerUnit,SilverValue,GST,TotalAmount,SupplierName,SupplierPhoneNo,DateofPurchase,Mass,ImageFile")] BuyingRawSilver BuyingRawSilver, IFormFile[] photos)
        {
            //    //if (ModelState.IsValid)
            //{
            //    if (BuyingRawSilver.SilverCode == 0)
            //        _context.Add(BuyingRawSilver);
            //    else
            //        _context.Update(BuyingRawSilver);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(BuyingRawSilver);
        //    public IActionResult AddOrEdit(BuyingRawSilver BuyingRawSilver, IFormFile[] photos)
        //{ 


                    BuyingRawSilver.Photos = new List<string>();
                  int acount = 1;
                   foreach (IFormFile photo in photos)
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", photo.FileName);
                        var stream = new FileStream(path, FileMode.Create);
                        await photo.CopyToAsync(stream);


    
                           BuyingRawSilver.ImageName = photo.FileName;
      
                       acount = acount + 1;
                        BuyingRawSilver.PCNAME = System.Net.Dns.GetHostName();
                        IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(BuyingRawSilver.PCNAME);
                        IPAddress[] addr = ipEntry.AddressList;
                        BuyingRawSilver.IPADDRESS = addr[addr.Length - 1].ToString();

                if (BuyingRawSilver.SilverCode == 0)
                        _context.Add(BuyingRawSilver);
                        else
                        _context.Update(BuyingRawSilver);
                        await _context.SaveChangesAsync();
                        BuyingRawSilver.Photos.Add(photo.FileName);
                    }
                    ViewBag.BuyingRawSilver = BuyingRawSilver;
                    TempData["name"] = "Records Added Successfully...!";

           
            return View("Update");
        }

        public async Task<IActionResult> Delete(int? SilverCode)
        {
            var silverid = await _context.BuyingRawSilver.FindAsync(SilverCode);
            _context.BuyingRawSilver.Remove(silverid);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
       
      
    }
}
