
namespace AirbnbGrpc.Models;
public class Review {
  public String _id { get; set; }
  public String date { get; set; }
  public String reviewer_id { get; set; }
  public String reviewer_name { get; set; }
  public String comments { get; set; }
}