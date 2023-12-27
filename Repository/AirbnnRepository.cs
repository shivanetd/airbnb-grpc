
using MongoDB.Driver;
using AirbnbGrpc.Models;
using Microsoft.Extensions.Options;

namespace AirbnbGrpc.Repository;

public class AirbnnRepository : IAirbnbRepository
{
    private readonly ILogger<AirbnnRepository> _logger;
    
    private readonly  IMongoCollection<ListingsAndReview> _listingsAndReviewsCollection; 

    public AirbnnRepository(ILogger<AirbnnRepository> logger, IOptions<MongoConfig> mongoConfig)
    {
        _logger = logger;
        
        var client = new MongoClient(mongoConfig.Value.ConnectionString);

        var database = client.GetDatabase(mongoConfig.Value.Database);

        _listingsAndReviewsCollection = database.GetCollection<ListingsAndReview>(mongoConfig.Value.Collection);

    }

    public Task<List<ListingsAndReview>> GetAllAirbnListingsAsync()
    {
       return _listingsAndReviewsCollection.Find(listingsAndReview => true).ToListAsync();
    }

    public Task<ListingsAndReview> GetAirbnbListingByIdAsync(string id)
    {
        return _listingsAndReviewsCollection.Find(listingsAndReview => listingsAndReview._id == id).FirstOrDefaultAsync();
    }
}