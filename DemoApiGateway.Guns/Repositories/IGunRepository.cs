using DemoApiGateway.Guns.Entities;

namespace DemoApiGateway.Guns.Repositories
{
    public interface IGunRepository
    {
        Task<List<Gun>> GetAll();
    }
}
