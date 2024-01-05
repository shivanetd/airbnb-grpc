using AirbnbGrpc.Repository;
using Grpc.Core;

namespace AirbnbGrpc.Services;


public class AirbnbService : Airbnb.AirbnbBase
{

    private readonly ILogger<AirbnbService> _logger;

    private readonly IAirbnbRepository _airbnbRepository;


    public AirbnbService(ILogger<AirbnbService> logger, IAirbnbRepository airbnbRepository)
    {
        _logger = logger;
        _airbnbRepository = airbnbRepository;
    }

    public override async Task<AirbnbListings> Listing(ListingRequest request, ServerCallContext context)
    {
        var listings = await _airbnbRepository.GetAirbnbListingByIdAsync(request.Id);

        var retModal = new AirbnbListings
        {
            ListingUrl = listings.listing_url,
            Name = listings.name,
            Summary = listings.summary,
            Space = listings.space,
            Description = listings.description,
            NeighborhoodOverview = listings.neighborhood_overview
        };

        return retModal;
    }


}

// public class AirbnbService : Airbnb.AirbnbBase
// {
//     private readonly ILogger<AirbnbService> _logger;
//     private readonly IMongoCollection<Host> _hosts;

//     public AirbnbService(ILogger<AirbnbService> logger, IMongoClient client, IOptions<MongoConfig> config)
//     {
//         _logger = logger;
//         _hosts = client.GetDatabase(config.Value.Database).GetCollection<Host>(config.Value.Collection);
//     }

//     public override async Task<HostReply> GetHost(HostRequest request, ServerCallContext context)
//     {
//         var host = await _hosts.Find(h => h.host_id == request.HostId).FirstOrDefaultAsync();
//         return new HostReply
//         {
//             Host = host
//         };
//     }

//     public override async Task<HostsReply> GetHosts(HostsRequest request, ServerCallContext context)
//     {
//         var hosts = await _hosts.Find(h => true).ToListAsync();
//         return new HostsReply
//         {
//             Hosts = { hosts }
//         };
//     }

//     public override async Task<HostReply> CreateHost(HostRequest request, ServerCallContext context)
//     {
//         await _hosts.InsertOneAsync(request.Host);
//         return new HostReply
//         {
//             Host = request.Host
//         };
//     }

//     public override async Task<HostReply> UpdateHost(HostRequest request, ServerCallContext context)
//     {
//         await _hosts.ReplaceOneAsync(h => h.host_id == request.Host.host_id, request.Host);
//         return new HostReply
//         {
//             Host = request.Host
//         };
//     }

//     public override async Task<HostReply> DeleteHost(HostRequest request, ServerCallContext context)
//     {
//         await _hosts.DeleteOneAsync(h => h.host_id == request.HostId);
//         return new HostReply
//         {
//             Host = request.Host
//         };
//     }
// }