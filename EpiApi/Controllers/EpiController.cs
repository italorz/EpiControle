using EpiApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EpiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpiController : ControllerBase
    {
        private readonly IEpiService _epiService;
        public EpiController(IEpiService epiService)
        {
            _epiService = epiService;
        }
    }
}
