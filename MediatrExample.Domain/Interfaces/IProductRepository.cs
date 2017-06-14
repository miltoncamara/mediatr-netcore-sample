using MediatrExample.Domain.Models;

namespace MediatrExample.Domain.Interfaces
{
    public interface IProductRepository
    {
        Product GetByName(string name);
        Product Save(Product model);
    }
}
