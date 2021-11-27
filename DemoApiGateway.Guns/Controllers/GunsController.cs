using DemoApiGateway.Guns.Entities;
using DemoApiGateway.Guns.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApiGateway.Guns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GunsController : ControllerBase
    {
        private readonly IGunRepository _gunRepository;

        public GunsController(IGunRepository gunRepository)
        {
            _gunRepository = gunRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Gun>>> Get()
        {
            return await _gunRepository.GetAll();
        }
    }
}
