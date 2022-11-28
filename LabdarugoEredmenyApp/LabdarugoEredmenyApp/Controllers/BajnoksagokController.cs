using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LabdarugoEredmenyApp.Data;
using LabdarugoEredmenyApp.Models;
using LabdarugoEredmenyApp.ViewModels;
using System.Collections.Specialized;

namespace LabdarugoEredmenyApp.Controllers
{
    public class BajnoksagokController : Controller
    {
        private LabdarugoEredmenyekContext _context;

        public BajnoksagokController(LabdarugoEredmenyekContext context)
        {
            _context = context;
        }

        public IActionResult Index(string? bajnoksagId, string sortString, string searchString)
        {
            //itt bajnoksag szerint kell ami kedvenc a meccseket betölteni majd abc sorrendben
            var Bajnoksagok = _context.Bajnoksagok.ToList();

            //search string alapjan kigyüjteni az adatokat és továbbitani a pl CsapatDetails page-re, tudjon betű alapján ajánlatokat adni ahonnan ki lehet választani egy csapatot kb igy hogy beirod a betűt és kiad minden olyan csapatot ahol az a betű benne van

            
            var Csapatok = _context.Csapatok.OrderBy(x => x.CsapatNev).Select(x => x.CsapatNev ).ToList();

            ViewBag.Csapatok = Csapatok;

            if (Guid.TryParse(bajnoksagId, out Guid guidOutput))
            {
                var bajnoksag = _context.Bajnoksagok.Where(x => x.BajnoksagId == guidOutput).Single();
                if (!bajnoksag.IsFavourite)
                {
                    bajnoksag.IsFavourite = true;
                }
                else
                {
                    bajnoksag.IsFavourite = false;
                }
                _context.SaveChanges();
            }

            var merkozesBajnoksag = _context.Merkozesek
                                                .Join(
                                                _context.Bajnoksagok,
                                                merkozes => merkozes.BajnoksagId,
                                                bajnoksag => bajnoksag.BajnoksagId,
                                                (_merkozes, _bajnoksag) => new
                                                {
                                                    IsFavourite = _bajnoksag.IsFavourite,
                                                    MerkozesId = _merkozes.MerkozesId,
                                                    Idopont = _merkozes.Idopont,
                                                    BajnoksagNev = _merkozes.BajnoksagNev,
                                                    HazaiCsapatNev= _merkozes.HazaiCsapatNev,
                                                    VendegCsapatNev = _merkozes.VendegCsapatNev,
                                                    Vegeredmeny = _merkozes.Vegeredmeny,
                                                }
                                                ).ToList();

            var idopontok = merkozesBajnoksag.OrderBy(x => x.Idopont).Select(x => x.Idopont.ToShortDateString()).Distinct().ToList();
            

            ViewBag.MerkozesIdopontok = new SelectList(idopontok);

            DateTime sortDate;

            var logok = _context.Csapatok.Select(x => new { x.CsapatNev, x.LogoCsapat }).ToList();

            ViewBag.Logok = logok;

            if (string.IsNullOrEmpty(sortString))
            {
                sortDate= DateTime.UtcNow.Date;
            }
            else 
            {

                sortDate=DateTime.Parse(sortString);
                merkozesBajnoksag = merkozesBajnoksag.Where(s => s.Idopont.Date == sortDate.Date).OrderByDescending(s => s.IsFavourite).ThenBy(s => s.BajnoksagNev).ToList();

                ViewBag.Merkozesek = merkozesBajnoksag;
                return PartialView("SortedMatchesByDatePartialView");

            }

            merkozesBajnoksag = merkozesBajnoksag.Where(s => s.Idopont.Date == sortDate.Date).OrderByDescending(s => s.IsFavourite).ThenBy(s => s.BajnoksagNev).ToList();

            ViewBag.Merkozesek = merkozesBajnoksag;

            ViewBag.Bajnoksagok = Bajnoksagok;
            return View("Index");
        }
        public IActionResult ListRelatedMatches(Guid bajnoksagId)
        {
            var relatedMatches = _context.Merkozesek.Where(x => x.BajnoksagId.Equals(bajnoksagId)).ToList();
            var logok = _context.Csapatok.Where(x => x.BajnoksagId.Equals(bajnoksagId)).Select(x => new { x.CsapatNev, x.LogoCsapat }).ToList();
            ViewBag.Logok = logok;
            return PartialView("BajnoksagMeccsekPartialView", relatedMatches);
        }

        
    }
    public class FormModel
    {
        public string FirstName { get; set; }
    }
}
