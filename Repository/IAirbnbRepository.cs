namespace AirbnbGrpc.Repository;

using AirbnbGrpc.Models;

public interface IAirbnbRepository
{
    Task<List<ListingsAndReview>> GetAllAirbnListingsAsync();

    Task<ListingsAndReview> GetAirbnbListingByIdAsync(string id);
}
