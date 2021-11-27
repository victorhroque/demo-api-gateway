using DemoApiGateway.Characters.Entities;

namespace DemoApiGateway.Characters.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {
        public List<Character> Characters = new();
        public CharacterRepository()
        {
            Characters.Add(new Character { Id = 1, Name = "Urban" });
            Characters.Add(new Character { Id = 1, Name = "Skin bot" });
            Characters.Add(new Character { Id = 1, Name = "Ghost" });
            Characters.Add(new Character { Id = 1, Name = "Mara" });
        }

        public Task<List<Character>> GetAll()
        {
            return Task.FromResult(Characters);
        }
    }
}
