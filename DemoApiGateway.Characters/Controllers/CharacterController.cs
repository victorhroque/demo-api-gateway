using DemoApiGateway.Characters.Entities;
using DemoApiGateway.Characters.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApiGateway.Characters.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterRepository _characterRepository;

        public CharacterController(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Character>>> Get()
        {
            return await _characterRepository.GetAll();
        }
    }
}
