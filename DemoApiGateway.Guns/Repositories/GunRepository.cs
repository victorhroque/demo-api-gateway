using DemoApiGateway.Guns.Entities;

namespace DemoApiGateway.Guns.Repositories
{
    public class GunRepository : IGunRepository
    {
        public List<Gun> Guns  = new();
        public GunRepository()
        {
            Guns.Add(new Gun { Id = 1, Name = "AK-47" });
            Guns.Add(new Gun { Id = 1, Name = "M4" });
            Guns.Add(new Gun { Id = 1, Name = "GKS" });
        }
        public Task<List<Gun>> GetAll()
        {
            return Task.FromResult(Guns);
        }
    }
}
