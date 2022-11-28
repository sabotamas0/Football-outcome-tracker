using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LabdarugoEredmenyApp.ViewModels
{
    public class AddMatchViewModel
    {
        public Guid VendegCsapatId { get; set; }
        public Guid HazaiCsapatId { get; set; }
        public string hazaiVegeredmeny { get; set; }
        public string VendegVegeredmeny { get; set; }
        public string HazaiFelideiEredmeny { get; set; }
        public string VendegFelideiEredmeny { get; set; }
        public string JegyzoKonyv { get; set; }
        public DateTime Időpont { get; set; }
        public string BajnoksagNev { get; set; }
        public Guid BajnoksagId { get; set; }   

    }
}
