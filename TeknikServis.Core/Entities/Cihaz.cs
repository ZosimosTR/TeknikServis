using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServis.Core.Entities
{
    public class Cihaz
    {
        public int CihazId { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string SeriNo { get; set; }

        public ICollection<ArizaKaydi> Arizalar { get; set; }
    }
}
