using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServis.Core.Entities
{
    public class ArizaKaydi
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public int CihazId { get; set; }
        public string ArizaAciklama { get; set; }
        public string Durum { get; set; } = "Beklemede";
        public DateTime KayitTarihi { get; set; } = DateTime.Now;

        public Musteri Musteri { get; set; }
        public Cihaz Cihaz { get; set; }
    }
}
