using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    //representing collections in MongoDb
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
