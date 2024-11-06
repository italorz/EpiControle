using EpiApi.Entities;
using EpiApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace EpiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpiController : ControllerBase
    {
        private readonly IEpiService _serviceEpi;

        public EpiController(IEpiService service)
        {
            _serviceEpi = service;
        }
        [HttpPost]
        public Task<Epi> CreateEpi(Epi epi)
        {
            return _serviceEpi.CreateEpi(epi);
        }

        

        [HttpGet]
        public async Task< ActionResult< IEnumerable< Epi>>> GetAll()
        {
            var lista = await _serviceEpi.GetAll();

            if (lista is null)
            {
                return NotFound();
            }

            return Ok(lista);
            
                        
        }



        [HttpGet("{id}",Name ="find-id")]
        public async Task<Epi> GetEpiById(int id)
        {
                var epi = await _serviceEpi.GetEpiById(id);
                
                return epi;

            


            
        }
        public Task<Epi> DeleteEpi(Epi epi)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Epi>> GetEpiByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public Task<Epi> UpdateEpi(Epi epi)
        {
            throw new NotImplementedException();
        }

        
    }
}
