using Api_Versioning.Models;

namespace Api_Versioning.Contracts;

public interface IProductService
{
    Task<Product> GetProductByIdAsync(int id, CancellationToken ct);
}
