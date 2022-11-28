using LabdarugoEredmenyApp.Models;
using System.Data;
using System.Data.Entity;

namespace LabdarugoEredmenyApp.Data
{
    public static class InitDb
    {
        public static List<Bajnoksag> SeedBajnoksagok()
        {
            var bajnoksagok = new List<Bajnoksag>
            {
                new Bajnoksag{BajnoksagId=Guid.Parse("3aab6379-74c5-4b28-8c5b-bc93ece03128"), BajnoksagNev="Premier League", LogoBajnoksag="https://cdn.freebiesupply.com/images/large/2x/premier-league-logo-black-and-white.png"},
                new Bajnoksag{BajnoksagId=Guid.Parse("8285a389-85ca-42a6-a331-1e8313284f14"), BajnoksagNev="OTP Bank Liga", LogoBajnoksag="https://upload.wikimedia.org/wikipedia/commons/9/96/OTP_Bank_Liga_logo.png",IsFavourite=false},
                new Bajnoksag{BajnoksagId=Guid.Parse("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"), BajnoksagNev="La liga", LogoBajnoksag="https://assets.laliga.com/assets/logos/laliga-h/laliga-h-1200x1200.png",IsFavourite=false},
                new Bajnoksag{BajnoksagId=Guid.Parse("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"), BajnoksagNev="Serie A", LogoBajnoksag="https://upload.wikimedia.org/wikipedia/commons/c/c2/Serie_A.png",IsFavourite=false }
            };

            return bajnoksagok;
        }
        public static List<Csapat> SeedCsapatok()
        {
            var csapatok = new List<Csapat>
            {
                
                new Csapat { CsapatId = Guid.NewGuid(), CsapatNev = "Chelsea", BajnoksagId =Guid.Parse("3aab6379-74c5-4b28-8c5b-bc93ece03128") ,LogoCsapat="https://assets.stickpng.com/images/580b57fcd9996e24bc43c4e1.png"},
                new Csapat { CsapatId = Guid.NewGuid(), CsapatNev = "Aston Villa", BajnoksagId =Guid.Parse("3aab6379-74c5-4b28-8c5b-bc93ece03128") ,LogoCsapat="https://assets.stickpng.com/images/580b57fcd9996e24bc43c4e4.png" },
                new Csapat { CsapatId = Guid.NewGuid(), CsapatNev = "Liverpool", BajnoksagId = Guid.Parse("3aab6379-74c5-4b28-8c5b-bc93ece03128"),LogoCsapat="https://assets.stickpng.com/images/580b57fcd9996e24bc43c4e5.png" },
                new Csapat { CsapatId = Guid.NewGuid(), CsapatNev = "Manchester United", BajnoksagId =Guid.Parse("3aab6379-74c5-4b28-8c5b-bc93ece03128"),LogoCsapat="https://assets.stickpng.com/images/580b57fcd9996e24bc43c4e7.png" },
                new Csapat { CsapatId = Guid.NewGuid(), CsapatNev = "Manchester City", BajnoksagId =Guid.Parse("3aab6379-74c5-4b28-8c5b-bc93ece03128"),LogoCsapat="https://upload.wikimedia.org/wikipedia/sco/thumb/e/eb/Manchester_City_FC_badge.svg/1024px-Manchester_City_FC_badge.svg.png" },
            
                new Csapat { CsapatId = Guid.NewGuid(), CsapatNev = "Vasas", BajnoksagId = Guid.Parse("8285a389-85ca-42a6-a331-1e8313284f14"),LogoCsapat= "https://seeklogo.com/images/V/vasas-sc-logo-7FC5081323-seeklogo.com.png"},
                new Csapat { CsapatId = Guid.NewGuid(), CsapatNev = "Ujpest", BajnoksagId = Guid.Parse("8285a389-85ca-42a6-a331-1e8313284f14") ,LogoCsapat="https://upload.wikimedia.org/wikipedia/hu/c/c7/%C3%9Ajpest_FC_gold.png"},
                new Csapat { CsapatId = Guid.NewGuid(), CsapatNev = "Ferencvarosi TC", BajnoksagId = Guid.Parse("8285a389-85ca-42a6-a331-1e8313284f14"),LogoCsapat="https://seeklogo.com/images/F/Fradi-logo-E674B9F1D6-seeklogo.com.png" },
                new Csapat { CsapatId = Guid.NewGuid(), CsapatNev = "Puskas Akademia", BajnoksagId =  Guid.Parse("8285a389-85ca-42a6-a331-1e8313284f14"),LogoCsapat="https://upload.wikimedia.org/wikipedia/en/thumb/4/44/Pusk%C3%A1s_Akad%C3%A9mia_FC_logo.svg/1200px-Pusk%C3%A1s_Akad%C3%A9mia_FC_logo.svg.png"},
                new Csapat { CsapatId = Guid.NewGuid(), CsapatNev = "Honved FC", BajnoksagId = Guid.Parse("8285a389-85ca-42a6-a331-1e8313284f14"),LogoCsapat="https://seeklogo.com/images/K/kispest-honved-fc-logo-023C06A231-seeklogo.com.png" },
           
                new Csapat { CsapatId = Guid.NewGuid(), CsapatNev = "Atletico Madrid", BajnoksagId = Guid.Parse("1400d27c-038b-45fb-8c6c-51e8eeb81cc0") ,LogoCsapat="https://logos-world.net/wp-content/uploads/2020/06/atletico-madrid-Logo.png"},
                new Csapat { CsapatId = Guid.NewGuid(), CsapatNev = "Valencia", BajnoksagId = Guid.Parse("1400d27c-038b-45fb-8c6c-51e8eeb81cc0") ,LogoCsapat="https://logos-world.net/wp-content/uploads/2020/11/Valencia-Emblem.png"},
                new Csapat { CsapatId = Guid.NewGuid(), CsapatNev = "FC Barcelona", BajnoksagId =Guid.Parse("1400d27c-038b-45fb-8c6c-51e8eeb81cc0")  ,LogoCsapat="https://assets.stickpng.com/images/584a9b3bb080d7616d298777.png"},
                new Csapat { CsapatId = Guid.NewGuid(), CsapatNev = "Celta Vigo", BajnoksagId = Guid.Parse("1400d27c-038b-45fb-8c6c-51e8eeb81cc0") ,LogoCsapat="https://upload.wikimedia.org/wikipedia/en/thumb/1/12/RC_Celta_de_Vigo_logo.svg/800px-RC_Celta_de_Vigo_logo.svg.png"},
                new Csapat { CsapatId = Guid.NewGuid(), CsapatNev = "Real Madrid", BajnoksagId =  Guid.Parse("1400d27c-038b-45fb-8c6c-51e8eeb81cc0"),LogoCsapat="https://assets.stickpng.com/images/584a9b47b080d7616d298778.png"},
            
                new Csapat { CsapatId = Guid.NewGuid(), CsapatNev = "AC Milan", BajnoksagId = Guid.Parse("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"),LogoCsapat= "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d0/Logo_of_AC_Milan.svg/361px-Logo_of_AC_Milan.svg.png?20201107091346"},
                new Csapat { CsapatId = Guid.NewGuid(), CsapatNev = "Juventus", BajnoksagId = Guid.Parse("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"),LogoCsapat= "https://upload.wikimedia.org/wikipedia/commons/d/da/Juventus_Logo.png"},
                new Csapat { CsapatId = Guid.NewGuid(), CsapatNev = "Inter", BajnoksagId = Guid.Parse("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff"),LogoCsapat="https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Inter_Old_Logo_%282007-2014%29.svg/1491px-Inter_Old_Logo_%282007-2014%29.svg.png"},
                new Csapat { CsapatId = Guid.NewGuid(), CsapatNev = "AS Roma", BajnoksagId = Guid.Parse("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff") ,LogoCsapat="https://logos-world.net/wp-content/uploads/2020/06/Roma-Logo.png"},
                new Csapat { CsapatId = Guid.NewGuid(), CsapatNev = "Napoli", BajnoksagId =Guid.Parse("c4cbe4ab-a7d1-4674-b3c9-d7f51a0213ff") ,LogoCsapat= "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e7/Logo_SSD_Napoli_Femminile_%282018%29.png/769px-Logo_SSD_Napoli_Femminile_%282018%29.png"}
            
            };

            return csapatok;
        }
    }
}
