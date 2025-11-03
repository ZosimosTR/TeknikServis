using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Core.Entities;
using TeknikServis.Core.Interfaces;

namespace TeknikServis.Business.Services
{
    public class ArizaService
    {
        private readonly IRepository<ArizaKaydi> _repository;

        public ArizaService(IRepository<ArizaKaydi> repository)
        {
            _repository = repository;
        }

        public async Task<List<ArizaKaydi>> GetAllAsync() => await _repository.GetAllAsync();
        public async Task<ArizaKaydi?> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);
        public async Task AddAsync(ArizaKaydi arizaKaydi)
        {
            await _repository.AddAsync(arizaKaydi);
            await _repository.SaveAsync();
        }
        public async Task UpdateAsync(ArizaKaydi arizaKaydi)
        {
            _repository.Update(arizaKaydi);
            await _repository.SaveAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity != null)
            {
                _repository.Delete(entity);
                await _repository.SaveAsync();
            }
        }
    }
}
