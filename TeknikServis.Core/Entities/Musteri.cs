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
        public string Telefon { get; set; }
        public string email { get; set; }

        public ICollection<ArizaKaydi> Arizalar { get; set; }

    }
}
