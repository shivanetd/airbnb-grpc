namespace AirbnbGrpc.Models;

public class Host
{
    public string host_id { get; set; }
    public string host_url { get; set; }
    public string host_name { get; set; }
    public string host_neighbourhood { get; set; }
    public string host_location { get; set; }
    public string host_about { get; set; }
    public string host_thumbnail_url { get; set; }
    public string host_picture_url { get; set; }
    public bool host_is_superhost { get; set; }
    public bool host_has_profile_pic { get; set; }
    public bool host_identity_verified { get; set; }
    public string host_listings_count { get; set; }
    public string host_total_listings_count { get; set; }
    public List<string> host_verifications { get; set; }
}