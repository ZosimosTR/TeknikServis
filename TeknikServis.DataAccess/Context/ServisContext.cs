using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Core.Entities;

namespace TeknikServis.DataAccess.Context
{
    public class ServisContext : DbContext
    {
        public ServisContext(DbContextOptions<ServisContext> options) : base(options)
        {
        }
        protected ServisContext()
        {
        }

        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<ArizaKaydi> ArizaKayitlari { get; set; }
        public DbSet<Cihaz> Cihazlar { get; set; }
    }
}
