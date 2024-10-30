using EpiApi.Data;
using EpiApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace EpiApi.Services
{
    public class EpiService : IEpiService
    {
       

        private readonly EpiContext _context= new EpiContext();

        public async Task<IEnumerable<Epi>> GetAll()
        {
            try
            {
                return await _context.epis.ToListAsync();


            }
            catch
            {
                throw;
            }
        }

        public async Task<Epi> GetEpiById(int id)
        {
            var epi = await _context.epis.FindAsync(id);
            return epi;
        }

        public async Task<IEnumerable<Epi>> GetEpiByNome(string nome)
        {
            IEnumerable<Epi> epis;
            if (!string.IsNullOrWhiteSpace(nome))
            {
                epis = await _context.epis.Where(n => n.nome.Contains(nome)).ToListAsync();
            }
            else
            {
                epis = await GetAll();
            }
            return epis;

        }
        public async Task<Epi> CreateEpi(Epi epi)
        {
            _context.epis.Add(epi);
            await _context.SaveChangesAsync();
            return epi;
        }
        public async Task<Epi> UpdateEpi(Epi epi)
        {
            _context.Entry(epi).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return epi;
        }
        public async Task<Epi> DeleteEpi(Epi epi)
        {
            _context.epis.Remove(epi);
            await _context.SaveChangesAsync();
            return epi;
        }
    }
}
