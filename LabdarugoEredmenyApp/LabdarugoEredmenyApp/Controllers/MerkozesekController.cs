using LabdarugoEredmenyApp.Data;
using LabdarugoEredmenyApp.Models;
using LabdarugoEredmenyApp.ViewModels;
using LabdarugoEredmenyApp.Validators;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using FluentValidation.Results;
using System;

namespace LabdarugoEredmenyApp.Controllers
{
    public class MerkozesekController : Controller
    {
        private LabdarugoEredmenyekContext _context;

        public MerkozesekController(LabdarugoEredmenyekContext context)
        {
            _context = context;
        }


        public IActionResult GetMerkozesById(Guid merkozesId)
        {
            //merkozes
            var merkozes = _context.Merkozesek.Where(x => x.MerkozesId == merkozesId).Single();
            ViewBag.Merkozes = merkozes;


            //hazai csapat legutobbi 3 mérközése a jelenlegi merkozesId idopontjanal kisebbek kellenek
            var hazaiCsapat = _context.Csapatok.Where(x => x.CsapatId == merkozes.HazaiCsapatId).Single();

            var hazai1 = _context.Merkozesek.Where(x => x.HazaiCsapatId == merkozes.HazaiCsapatId && x.Idopont < merkozes.Idopont).ToList();

            var hazaiOrderby1 = hazai1.OrderByDescending(x => x.Idopont).ToList();

            var hazai2 = _context.Merkozesek.Where(x => x.VendegCsapatId == merkozes.HazaiCsapatId && x.Idopont < merkozes.Idopont).ToList();

            var hazaiOrderby2 = hazai2.OrderByDescending(x => x.Idopont).ToList();


            //kell egy olyan halmaz amiben megvan hogy éppen hazai vagy vendég a hazai csapat ha vendég akkor forditva listázunk ha nem akkor normálisan

            var ossz= hazaiOrderby2.Union(hazaiOrderby1).Take(3).ToList();


            List<(bool, Merkozes)> VendegEHazaiiak = new List<(bool, Merkozes)>();

            foreach(var Merkozes in ossz)
            {
                if(Merkozes.HazaiCsapatId==hazaiCsapat.CsapatId)
                {
                    VendegEHazaiiak.Add((false, Merkozes));
                }
                else 
                {
                    VendegEHazaiiak.Add((true, Merkozes));
                }
            }

            ViewBag.HazaiMerkozesek = VendegEHazaiiak;


            //vendeg csapat legutobbi 3 mérközése jelenlegi merkozesId idopontjanal kisebbek kellenek
            var vendegCsapat = _context.Csapatok.Where(x => x.CsapatId == merkozes.VendegCsapatId).Single();


            var vendeg1 = _context.Merkozesek.Where(x => x.HazaiCsapatId == merkozes.VendegCsapatId && x.Idopont < merkozes.Idopont).ToList();

            var vendegOrderBy1 = vendeg1.OrderByDescending(x => x.Idopont).ToList();

            var vendeg2 = _context.Merkozesek.Where(x => x.VendegCsapatId == merkozes.VendegCsapatId && x.Idopont < merkozes.Idopont).ToList();

            var vendegOrderBy2 = vendeg2.OrderByDescending(x => x.Idopont).ToList();


            //kell egy olyan halmaz amiben megvan hogy éppen hazai vagy vendég a vendeg csapat ha vendég akkor forditva listázunk ha nem akkor normálisan

            var ossz2 = vendegOrderBy2.Union(vendegOrderBy1).Take(3).ToList();


            List<(bool, Merkozes)> VendegEVendegek = new List<(bool, Merkozes)>();

            foreach (var Merkozes in ossz2)
            {
                if (Merkozes.HazaiCsapatId == vendegCsapat.CsapatId)
                {
                    VendegEVendegek.Add((false, Merkozes));
                }
                else
                {
                    VendegEVendegek.Add((true, Merkozes));
                }
            }

            ViewBag.VendegMerkozesek = VendegEVendegek;

            //logok
            var logok = _context.Csapatok.Select(x => new { x.CsapatNev, x.LogoCsapat }).ToList();

            ViewBag.Logok = logok;
            return View("MerkozesDetails");
        }

        [HttpGet]
        public IActionResult CreateNewMatch(Guid bajnoksagId, AddMatchViewModel? model)
        {
            var logok = _context.Csapatok.Where(x => x.BajnoksagId.Equals(bajnoksagId)).Select(x => new { x.CsapatId, x.LogoCsapat }).ToList();
            ViewBag.Logok = logok;

            var bajnoksagNev = _context.Bajnoksagok.Where(x => x.BajnoksagId.Equals(bajnoksagId)).Select(x => x.BajnoksagNev).Single();
            model.BajnoksagNev = bajnoksagNev;

            var CsapatNevevek = _context.Csapatok.Where(x => x.BajnoksagId.Equals(bajnoksagId))
                .Select(x => new { x.CsapatNev, x.CsapatId }).ToList();

            ViewBag.CsapatNevek = new SelectList(CsapatNevevek, nameof(Csapat.CsapatId), nameof(Csapat.CsapatNev));

            return View("CreateNewMatch", model);
        }

        [HttpPost]
        public IActionResult CreateNewMatch(AddMatchViewModel model)
        {
            var logok = _context.Csapatok.Where(x => x.BajnoksagId.Equals(model.BajnoksagId)).Select(x => new { x.CsapatId, x.LogoCsapat }).ToList();
            ViewBag.Logok = logok;

            var bajnoksagNev = _context.Bajnoksagok.Where(x => x.BajnoksagId.Equals(model.BajnoksagId)).Select(x => x.BajnoksagNev).Single();
            model.BajnoksagNev = bajnoksagNev;

            var CsapatNevevek = _context.Csapatok.Where(x => x.BajnoksagId.Equals(model.BajnoksagId))
                .Select(x => new { x.CsapatNev, x.CsapatId }).ToList();

            ViewBag.CsapatNevek = new SelectList(CsapatNevevek, nameof(Csapat.CsapatId), nameof(Csapat.CsapatNev));
            AddMatchViewModelValidator validator = new AddMatchViewModelValidator(_context);

            ValidationResult result = validator.Validate(model);

            if (result.IsValid)
            {
                //eltárolo logika
                string Vegeredmeny = model.hazaiVegeredmeny + ":" + model.VendegVegeredmeny;

                string FelideiEredmeny = model.HazaiFelideiEredmeny + ":" + model.VendegFelideiEredmeny;

                var hazaiCsapatNev = _context.Csapatok.Where(x => x.CsapatId == model.HazaiCsapatId).Select(x => x.CsapatNev).Single();
                var vendegCsapatNev = _context.Csapatok.Where(x => x.CsapatId == model.VendegCsapatId).Select(x => x.CsapatNev).Single();

                Merkozes ujMerkozes = new Merkozes(Guid.NewGuid(), model.Időpont, Vegeredmeny, FelideiEredmeny, model.JegyzoKonyv, hazaiCsapatNev, vendegCsapatNev, model.HazaiCsapatId, model.VendegCsapatId, model.BajnoksagNev, model.BajnoksagId);

                var hazaiCsapat = _context.Csapatok.Where(x => x.CsapatId == model.HazaiCsapatId).Single();
                var vendegCsapat = _context.Csapatok.Where(x => x.CsapatId == model.VendegCsapatId).Single();

                if (int.Parse(model.VendegVegeredmeny) > int.Parse(model.hazaiVegeredmeny))
                {
                    ++hazaiCsapat.VesztesSzamlalo;
                    ++vendegCsapat.GyozelemSzamlalo;
                }
                else if (int.Parse(model.VendegVegeredmeny) == int.Parse(model.hazaiVegeredmeny))
                {
                    //döntetlen de nem kell eltárolni?
                    ++hazaiCsapat.DontetlenSzamlalo;
                    ++vendegCsapat.DontetlenSzamlalo;
                }
                else
                {
                    ++hazaiCsapat.GyozelemSzamlalo;
                    ++vendegCsapat.VesztesSzamlalo;
                }

                _context.Merkozesek.Add(ujMerkozes);
                _context.SaveChanges();

                return RedirectToAction("Index", "Bajnoksagok");
            }
            else
            {
                foreach (ValidationFailure failer in result.Errors)
                {
                    ModelState.AddModelError(failer.PropertyName, failer.ErrorMessage);

                }
                return View("CreateNewMatch", model);
            }
        }

        [HttpGet]
        public void SaveToXml(Guid merkozesId)
        {
            if (merkozesId != null || merkozesId != Guid.Empty)
            {
                var merkozes = _context.Merkozesek.Where(x => x.MerkozesId == merkozesId).Single();
                string xmlMessage = MySerializer<Merkozes>.Serialize(merkozes);
                
                System.IO.File.WriteAllText("lementetMerkozesek/" + merkozes.MerkozesId + ".xml", xmlMessage);
            }
            
        }
    }
}
