using Catalog.Api.Entities;
using MongoDB.Driver;

namespace Catalog.Api.Dal
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}