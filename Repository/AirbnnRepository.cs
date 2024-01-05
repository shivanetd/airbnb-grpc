
using MongoDB.Driver;
using AirbnbGrpc.Models;
using Microsoft.Extensions.Options;

namespace AirbnbGrpc.Repository;


public class AirbnnRepository : IAirbnbRepository
{
    private readonly ILogger<AirbnnRepository> _logger;
    
    private readonly  IMongoCollection<ListingsAndReview> _listingsAndReviewsCollection; 

    public AirbnnRepository(ILogger<AirbnnRepository> logger, IConfiguration configuration)
    {
        _logger = logger;
        var config = configuration.GetSection("MongoConfig").Get<MongoConfig>();
        
        var client = new MongoClient(config.ConnectionString);

        var database = client.GetDatabase(config.Database);

        _listingsAndReviewsCollection = database.GetCollection<ListingsAndReview>(config.Collection);

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