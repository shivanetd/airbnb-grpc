
using MongoDB.Driver;
using AirbnbGrpc.Models;

namespace AirbnbGrpc.Repository;

public class AirbnnRepository : IAirbnbRepository
{
    private readonly ILogger<AirbnnRepository> _logger;
    private readonly  IMongoCollection<ListingsAndReview> _listingsAndReviewsCollection; 

    public AirbnnRepository(ILogger<AirbnnRepository> logger, IConfiguration configuration)
    {
        _logger = logger;
        
        var mongoConfig = configuration.GetSection("MongoConfig").Get<MongoConfig>();

        var client = new MongoClient(mongoConfig.ConnectionString);

        var database = client.GetDatabase(mongoConfig.Database);

        _listingsAndReviewsCollection = database.GetCollection<ListingsAndReview>(mongoConfig.Collection);

    }

    public Task<List<ListingsAndReview>> GetAllAirbnListingsAsync()
    {
       return _listingsAndReviewsCollection.Find(listingsAndReview => true).ToListAsync();
    }
}