using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Core.Entities;
using TeknikServis.Core.Interfaces;

namespace TeknikServis.Business.Services
{
    public class CihazService
    {
        private readonly IRepository<Cihaz> _repository;

        public CihazService(IRepository<Cihaz> repository)
        {
            _repository = repository;
        }

        public async Task<List<Cihaz>> GetAllAsync() => await _repository.GetAllAsync();
        public async Task<Cihaz?> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);
        public async Task AddAsync(Cihaz cihaz)
        {
            await _repository.AddAsync(cihaz);
            await _repository.SaveAsync();
        }
        public async Task UpdateAsync(Cihaz cihaz)
        {
            _repository.Update(cihaz);
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
