namespace AirbnbGrpc.Models;


public class Address
{
    public string street { get; set; }
    public string suburb { get; set; }
    public string government_area { get; set; }
    public string market { get; set; }
    public string country { get; set; }
    public string country_code { get; set; }
    public Location location { get; set; }
}