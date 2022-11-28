using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LabdarugoEredmenyApp.Models
{
    public class Merkozes
    {
        public Merkozes() { }
        public Merkozes(Guid merkozesId,DateTime idopont,string vegeredmeny,string felideiEredmeny,string jegyzokonyv,string hazaiNev,string vendegNev, Guid hazaiId,Guid vendegId,string bajnoksagNev,Guid bajnoksagId) 
        {
            MerkozesId= merkozesId;
            Idopont = idopont;
            Vegeredmeny= vegeredmeny;
            FelideiEredmeny= felideiEredmeny;
            JegyzoKonyv= jegyzokonyv;
            HazaiCsapatNev= hazaiNev;
            VendegCsapatNev= vendegNev;
            HazaiCsapatId = hazaiId;
            VendegCsapatId= vendegId;
            BajnoksagNev= bajnoksagNev;
            BajnoksagId= bajnoksagId;
        }
        public Guid MerkozesId { get; set; }
        [BindProperty]
        public DateTime Idopont { get; set; }
        [Required]
        public string Vegeredmeny { get; set; }
        [Required]
        public string FelideiEredmeny { get; set; }
        [Required]
        public string JegyzoKonyv { get; set; }

        public string HazaiCsapatNev { get; set; }
        public string VendegCsapatNev { get; set; }
        public Guid HazaiCsapatId { get; set; }
        public Guid VendegCsapatId { get; set; }
        public string BajnoksagNev { get; set; }
        public Guid BajnoksagId { get; set; }

    }
}
