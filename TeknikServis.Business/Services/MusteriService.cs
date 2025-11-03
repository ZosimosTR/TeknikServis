using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Core.Entities;
using TeknikServis.Core.Interfaces;

namespace TeknikServis.Business.Services
{
    public class MusteriService
    {
        private readonly IRepository<Musteri> _repository;

        public MusteriService(IRepository<Musteri> repository)
        {
            _repository = repository;
        }

        public async Task<List<Musteri>> GetAllAsync() => await _repository.GetAllAsync();
        public async Task<Musteri?> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);
        public async Task AddAsync(Musteri musteri)
        {
            await _repository.AddAsync(musteri);
            await _repository.SaveAsync();
        }
        public async Task UpdateAsync(Musteri musteri)
        {
            _repository.Update(musteri);
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
