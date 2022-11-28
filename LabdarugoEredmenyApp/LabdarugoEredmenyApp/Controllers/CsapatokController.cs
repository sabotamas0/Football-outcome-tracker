using LabdarugoEredmenyApp.Data;
using LabdarugoEredmenyApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LabdarugoEredmenyApp.Controllers
{
    public class CsapatokController : Controller
    {
        private LabdarugoEredmenyekContext _context;

        public CsapatokController(LabdarugoEredmenyekContext context)
        {
            _context = context;
        }

        public IActionResult CsapatDetails()
        {
            string csapatNev = Request.Form["SSSEEEAAAARRRCCCH"];

            if (!_context.Csapatok.Any(u => u.CsapatNev.ToLower()==csapatNev.ToLower()))
            {
                return RedirectToAction("Index", "Bajnoksagok");
            }

            var csapat = _context.Csapatok.Where(x => x.CsapatNev.ToLower() == csapatNev.ToLower()).Single();

            var csapat1 = _context.Merkozesek.Where(x => x.HazaiCsapatId == csapat.CsapatId).ToList();

            var csapatOrderBy1 = csapat1.OrderByDescending(x => x.Idopont).ToList();

            var csapat2 = _context.Merkozesek.Where(x => x.VendegCsapatId == csapat.CsapatId).ToList();

            var csapatOrderBy2 = csapat2.OrderByDescending(x => x.Idopont).ToList();


            //kell egy olyan halmaz amiben megvan hogy éppen hazai vagy vendég a vendeg csapat ha vendég akkor forditva listázunk ha nem akkor normálisan

            var ossz2 = csapatOrderBy2.Union(csapatOrderBy1).ToList();


            List<(bool, Merkozes)> VendegECsapat = new List<(bool, Merkozes)>();

            foreach (var Merkozes in ossz2)
            {
                if (Merkozes.HazaiCsapatId == csapat.CsapatId)
                {
                    VendegECsapat.Add((false, Merkozes));
                }
                else
                {
                    VendegECsapat.Add((true, Merkozes));
                }
            }

            var logok = _context.Csapatok.Select(x => new { x.CsapatNev, x.LogoCsapat }).ToList();

            ViewBag.Logok = logok;

            var eredmenyek = _context.Csapatok.Where(x => x.CsapatId == csapat.CsapatId).Select(x => new { x.VesztesSzamlalo, x.DontetlenSzamlalo, x.GyozelemSzamlalo }).ToList();

            List<int> vereseg= new List<int>();
            List<int> gyozelem = new List<int>();
            List<int> dontetlen = new List<int>();
            foreach (var eredmeny in eredmenyek)
            {
                vereseg.Add(eredmeny.VesztesSzamlalo);
                dontetlen.Add(eredmeny.DontetlenSzamlalo);
                gyozelem.Add(eredmeny.GyozelemSzamlalo);
            }

            ViewBag.vereseg = vereseg;
            ViewBag.gyozelem = gyozelem;
            ViewBag.dontetlen = dontetlen;
            ViewBag.Merkozesek = VendegECsapat;

            return View();
            
        }
        
    }
}
