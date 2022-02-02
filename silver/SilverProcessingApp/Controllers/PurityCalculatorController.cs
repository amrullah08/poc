using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SilverProcessingApp.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Data;
using System.IO;
using ClosedXML.Excel;
using System.Text;
using System.Globalization;
using System.Security.Claims;
using SilverProcessingApp.Data;
using SilverProcessingApp.Areas.Identity.Data;
using System.Net;
using Microsoft.AspNetCore.Authorization;

namespace SilverProcessingApp.Controllers
{
    public class PurityCalculatorController : Controller
    {

        private readonly SilverContext _context;
        private readonly UserManager<SilverProcessingAppUser> _UserManager;
        //constructor
        public PurityCalculatorController(SilverContext context, UserManager<SilverProcessingAppUser> UserManager)
        {
          
            _context = context;
            _UserManager = UserManager;
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index(int id)
        {
            //if (id == 0)
            //    return View(await _context.PurityCalculator.ToListAsync());
            //else
            return View(await _context.ScrapSilverPurityCalculatorJobDetails.Where(i => i.Pido == id).ToListAsync());
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index2()
        {
            List<ScrapSilverPurityCalculatorJobDetails> ScrapSilverPurityCalculatorJobDetails = new List<ScrapSilverPurityCalculatorJobDetails>();
            List<ScrapSilverPurityConvertorJob> ScrapSilverPurityConvertorJob = new List<ScrapSilverPurityConvertorJob>();


            var JoinAndViewModel = from s in _context.ScrapSilverPurityConvertorJob
                                   join st in _context.ScrapSilverPurityCalculatorJobDetails
                        //.GroupBy(x => true)
                        //.Select(x => new
                        //{
                        //    FinalPurity = x.Sum(y => y.FinalPurity),
                        //    FinalValue = x.Sum(y => y.FinalValue)
                        //})
                        on s.ProductNo equals st.ProductNumber into st2
                                   from st in st2.DefaultIfEmpty()
                                   select new JoinAndViewModel { PCon = s, PCal = st };
            await _context.ScrapSilverPurityConvertorJob.ToListAsync();



            //.Sum(p => p.QuantityinGms);
            //return View(await _context.PurityConvertor.ToListAsync());
            return View(JoinAndViewModel);
        }


        //public IActionResult AddOrEdit(int ids = 0)
        //{
        //    if (ids == 0)
        //        return View(new PurityCalculator());
        //    else
        //        return View(_context.PurityCalculator.Find(ids));
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> AddOrEdit([Bind("ids,QuantityinGms,PercentageTomakepure,PureSilver,ExpectedfinalPurity,FinalPurity,FinalValue")] PurityCalculator PurityCalculator)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (PurityCalculator.ids == 0)
        //        {
        //            //PurityCalculator.id = 1;
        //            //--example--  1200 * 82/100 = 984 ---//pure silver
        //            PurityCalculator.PureSilver = PurityCalculator.QuantityinGms * PurityCalculator.PercentageTomakepure / 100;

        //            _context.Add(PurityCalculator);

        //            var ImpureQuantity = _context.PurityCalculator
        //                                    .FromSqlRaw("Select Sum(QuantityinGms) as QuantityinGms from PurityCalculator")
        //                                  .ToString();

        //            var pureQuantity = _context.PurityCalculator
        //                                .FromSqlRaw("Select Sum(PureSilver) as PureSilver from PurityCalculator")
        //                                .ToString();


        //            PurityCalculator.TotalImpureQuantity = Convert.ToInt32(ImpureQuantity);
        //            PurityCalculator.TotalPureQuantity = Convert.ToInt32(pureQuantity);

        //            //example---2394/77*100= 3109 //final purity
        //            PurityCalculator.FinalPurity = PurityCalculator.TotalImpureQuantity / PurityCalculator.ExpectedfinalPurity * 100;

        //            //ecample--- 3109-2700 = 409  //final value
        //            PurityCalculator.FinalValue = PurityCalculator.FinalPurity - PurityCalculator.QuantityinGms;

        //        }

        //        else
        //        {
        //            _context.Update(PurityCalculator);
        //            await _context.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }
        //    }
        //    ViewBag.PurityCalculator = PurityCalculator;
        //    TempData["name"] = "Records Added Successfully...!";
        //    return View("Update");
        //}

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ScrapSilverPurityConvertorJob viewModel = new ScrapSilverPurityConvertorJob();
            viewModel.PurityCalculators = new List<ScrapSilverPurityCalculatorJobDetails>();

            ScrapSilverPurityCalculatorJobDetails row1 = new ScrapSilverPurityCalculatorJobDetails();
            ScrapSilverPurityCalculatorJobDetails row2 = new ScrapSilverPurityCalculatorJobDetails();
            ScrapSilverPurityCalculatorJobDetails row3 = new ScrapSilverPurityCalculatorJobDetails();

            viewModel.PurityCalculators.Add(row1);
            //viewModel.PurityCalculators.Add(row2);
            //viewModel.PurityCalculators.Add(row3);
            return View(viewModel);
        }

        //----------------------------------------------------
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ScrapSilverPurityConvertorJob PurityConvertor, ScrapSilverPurityCalculatorJobDetails ScrapSilverPurityCalculatorJobDetails)
        {
            if (ModelState.IsValid)
            {
                string userId = _UserManager.GetUserId(User);
                string username = _UserManager.GetUserName(User);

                String pcname = System.Net.Dns.GetHostName();
                IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(pcname);
                IPAddress[] addr = ipEntry.AddressList;
                String ipaddress = addr[addr.Length - 1].ToString();

                var PurityConv = new ScrapSilverPurityConvertorJob()
                {

                    Pid = PurityConvertor.Pid,
                    ProductNo = PurityConvertor.ProductNo,
                    Description = PurityConvertor.Description,
                    ExpectedfinalPurity = PurityConvertor.ExpectedfinalPurity,
                    Dateofinput = PurityConvertor.Dateofinput,
                    FromBuyer = PurityConvertor.FromBuyer,
                    ToEndUser = PurityConvertor.ToEndUser,
                    PCNAME = pcname,
                    IPADDRESS = ipaddress,
                    UserId = userId,
                    UserName = username,
                    LastModified = DateTime.Now
            };

                _context.ScrapSilverPurityConvertorJob.Add(PurityConv);
                await _context.SaveChangesAsync();

                foreach (var i in ScrapSilverPurityCalculatorJobDetails.PurityCalculators)
                {

                    int pidi = PurityConvertor.ProductNo;

                    var pidd = _context.ScrapSilverPurityConvertorJob
                               .Where(u => u.ProductNo == pidi)
                               .Select(u => u.Pid)
                               .SingleOrDefault();

                    //--example--  1200 * 82/100 = 984 ---//pure silver
                    i.PureSilver = i.QuantityinGms * i.PercentageTomakepure / 100;

                    var ImpureQuantity = _context.ScrapSilverPurityCalculatorJobDetails.Sum(p => p.QuantityinGms);
                    var pureQuantity = _context.ScrapSilverPurityCalculatorJobDetails.Sum(p => p.PureSilver);

                    i.TotalImpureQuantity = Convert.ToInt32(ImpureQuantity);
                    i.TotalPureQuantity = Convert.ToInt32(pureQuantity);

                    //example---2394/77*100= 3109 //final purity
                    //if (i.TotalImpureQuantity <= 0)
                    //{
                    i.FinalPurity = i.QuantityinGms / PurityConvertor.ExpectedfinalPurity * 100;
                    //}
                    //else
                    //{
                    //    i.TotalImpureQuantity = i.TotalImpureQuantity + i.QuantityinGms;
                    //    i.FinalPurity = i.TotalImpureQuantity / PurityConvertor.ExpectedfinalPurity * 100;
                    //}

                    //   

                    //ecample--- 3109-2700 = 409  //final value

                    i.FinalValue = i.FinalPurity - i.QuantityinGms;

                    int pn = PurityConvertor.ProductNo;
                    var efp = PurityConvertor.ExpectedfinalPurity;
                    var PurityCal = new ScrapSilverPurityCalculatorJobDetails()
                    {
                        Pido = pidd,
                        SilverCode = i.SilverCode,
                        QuantityinGms = i.QuantityinGms,
                        PercentageTomakepure = i.PercentageTomakepure,
                        PureSilver = i.PureSilver,
                        ExpectedfinalPurity = efp,
                        FinalPurity = i.FinalPurity,
                        FinalValue = i.FinalValue,
                        ProductNumber = pn,
                        Description = i.Description,

                        IPADDRESS = ipaddress,
                        PCNAME = pcname,
                        UserId = userId,
                        UserName = username,
                        LastModified = DateTime.Now

                    };

                    _context.ScrapSilverPurityCalculatorJobDetails.Add(PurityCal);
                    await _context.SaveChangesAsync();
                }
                TempData["name"] = "Records Added Successfully...!";
                //return RedirectToAction(nameof(Create));
                await _context.ScrapSilverPurityCalculatorJobDetails.ToListAsync();
                await _context.ScrapSilverPurityConvertorJob.ToListAsync();
                //return RedirectToAction(nameof(Index));
                return RedirectToAction(nameof(Index2));
            }
            return View(PurityConvertor);
        }

        //----------------------------------------------------

        public IActionResult EditPC(int Id = 0)
        {
            if (Id == 0)
                return View(new ScrapSilverPurityCalculatorJobDetails());
            else
                return View(_context.ScrapSilverPurityCalculatorJobDetails.Find(Id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPC([Bind("ProductNumber,SilverCode,QuantityinGms,PercentageTomakepure,PureSilver,ExpectedfinalPurity,FinalPurity,FinalValue,Pido")] ScrapSilverPurityCalculatorJobDetails PurityCalculator, int id)
        {
            if (ModelState.IsValid)
            {

                //int pidi = PurityConvertor.ProductNo;

                //var pidd = _context.PurityConvertor
                //           .Where(u => u.ProductNo == pidi)
                //           .Select(u => u.Pid)
                //           .SingleOrDefault();

                PurityCalculator.PureSilver = PurityCalculator.QuantityinGms * PurityCalculator.PercentageTomakepure / 100;

                var ImpureQuantity = _context.ScrapSilverPurityCalculatorJobDetails.Sum(p => p.QuantityinGms);
                var pureQuantity = _context.ScrapSilverPurityCalculatorJobDetails.Sum(p => p.PureSilver);

                PurityCalculator.TotalImpureQuantity = Convert.ToInt32(ImpureQuantity);
                PurityCalculator.TotalPureQuantity = Convert.ToInt32(pureQuantity);

                PurityCalculator.FinalPurity = PurityCalculator.QuantityinGms / PurityCalculator.ExpectedfinalPurity * 100;


                PurityCalculator.FinalValue = PurityCalculator.FinalPurity - PurityCalculator.QuantityinGms;


                if (PurityCalculator.SilverCode == 0)
                    _context.Add(PurityCalculator);
                else
                    _context.Update(PurityCalculator);
                await _context.SaveChangesAsync();
                TempData["name"] = "Records Updated Successfully...!";
                return RedirectToAction(nameof(Index2));
            }
            return View(PurityCalculator);
        }


        public async Task<IActionResult> Delete(int? ids)
        {
            var SCode = await _context.ScrapSilverPurityCalculatorJobDetails.FindAsync(ids);
            _context.ScrapSilverPurityCalculatorJobDetails.Remove(SCode);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult dateforexcel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult dateforexcel(dateforexcel ds)
        {
       
            var products = _context.ScrapSilverPurityConvertorJob.ToList();
            dateforexcel ss = new dateforexcel();


            var JoinAndViewModel = from s in _context.ScrapSilverPurityConvertorJob
                                   join st in _context.ScrapSilverPurityCalculatorJobDetails
                        on s.ProductNo equals st.ProductNumber into st2
                                   from st in st2.DefaultIfEmpty()
                                   select new JoinAndViewModel { PCon = s, PCal = st };
                  _context.ScrapSilverPurityConvertorJob.ToList();


            DateTime asd = Convert.ToDateTime(ds.FromDate);
            DateTime asf = Convert.ToDateTime(ds.ToDate);
            //var sDate = DateTime.ParseExact(Convert.ToDateTime(ds.FromDate), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //var eDate = DateTime.ParseExact(Convert.ToDateTime(ds.ToDate), "yyyy-MM-dd", CultureInfo.InvariantCulture);

            var fireData = _context.ScrapSilverPurityConvertorJob.Where(b => (b.Dateofinput >= asd && b.Dateofinput < asf)).ToList();


            DataTable dtProduct = new DataTable("PurityDetails");
            dtProduct.Columns.AddRange(new DataColumn[9] {  new DataColumn("ProductNo"),
                                            new DataColumn("Description"),
                                            new DataColumn("ExpectedfinalPurity"),
                                             new DataColumn("QuantityinGms"),
                                             new DataColumn("PercentageTomakepure"),
                                             new DataColumn("PureSilver"),
                                             new DataColumn("FinalPurity"),
                                             new DataColumn("FinalValue"),
                                            new DataColumn("Dateofinput") });
            foreach (var product in JoinAndViewModel)
            {
                dtProduct.Rows.Add(product.PCon.ProductNo, product.PCon.Description, product.PCon.ExpectedfinalPurity,product.PCal.QuantityinGms,product.PCal.PercentageTomakepure,product.PCal.PureSilver,product.PCal.FinalPurity,product.PCal.FinalValue, product.PCon.Dateofinput);
 
            }


            using (XLWorkbook wb = new XLWorkbook())
            {
             
                wb.Worksheets.Add(dtProduct);

                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Product.xlsx");
                }
            }


        }



    }
}
