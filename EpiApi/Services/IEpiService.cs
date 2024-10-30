using EpiApi.Entities;

namespace EpiApi.Services;

public interface IEpiService
{
    Task<IEnumerable<Epi>> GetAll();
    Task<Epi> GetEpiById(int id);
    Task<IEnumerable<Epi>> GetEpiByNome(string nome);
    Task<Epi> CreateEpi(Epi epi);
    Task<Epi> UpdateEpi(Epi epi);
    Task<Epi> DeleteEpi(Epi epi);
}
