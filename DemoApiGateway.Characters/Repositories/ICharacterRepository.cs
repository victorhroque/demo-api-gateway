using DemoApiGateway.Characters.Entities;

namespace DemoApiGateway.Characters.Repositories
{
    public interface ICharacterRepository
    {
        Task<List<Character>> GetAll();
    }
}
