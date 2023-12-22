namespace AirbnbGrpc.Models;

public class Location
{
    public string type { get; set; }
    public List<string> coordinates { get; set; }
    public bool is_location_exact { get; set; }
}