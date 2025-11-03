using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServis.Core.Entities
{
    public class Musteri
    {
        public int MusteriId { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }

        public string AdSoyad => $"{MusteriAdi} {MusteriSoyadi}";
        public string Telefon { get; set; }
        public string Email { get; set; }

        public ICollection<ArizaKaydi> Arizalar { get; set; } = new List<ArizaKaydi>();

    }
}
