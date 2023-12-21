
namespace AirbnbGrpc.Repository
{
    public interface IAirbnbRepository
    {
        Task<AirbnbResponse> GetAirbnbResponseAsync(AirbnbRequest airbnbRequest);
    }
}