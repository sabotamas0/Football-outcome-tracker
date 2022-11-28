using System.ComponentModel.DataAnnotations;

namespace LabdarugoEredmenyApp.Models
{
    public class Bajnoksag
    {
        public Guid BajnoksagId { get; set; }
        [Required]
        public string BajnoksagNev { get; set; }
        public bool IsFavourite { get; set; }
        public string LogoBajnoksag { get; set; }
    }
}
