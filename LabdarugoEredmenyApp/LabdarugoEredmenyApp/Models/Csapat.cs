using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabdarugoEredmenyApp.Models
{
    public class Csapat
    {
        public Guid CsapatId { get; set; }
        [Required]
        public string CsapatNev { get; set; }
        [Required]
        public int GyozelemSzamlalo { get; set; }
        [Required]
        public int VesztesSzamlalo { get; set; }
        [Required]
        public int DontetlenSzamlalo { get; set; }
        public Guid BajnoksagId { get; set; } // csak hazai bajnokságok vannak ebben az implementacioban
        public string LogoCsapat { get; set; }
    }
}
