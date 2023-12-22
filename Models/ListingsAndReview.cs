namespace AirbnbGrpc.Models;

public class ListingsAndReview
    {
        public string _id { get; set; }
        public string listing_url { get; set; }
        public string name { get; set; }
        public string summary { get; set; }
        public string space { get; set; }
        public string description { get; set; }
        public string neighborhood_overview { get; set; }
        public string notes { get; set; }
        public string transit { get; set; }
        public string access { get; set; }
        public string interaction { get; set; }
        public string house_rules { get; set; }
        public string property_type { get; set; }
        public string room_type { get; set; }
        public string bed_type { get; set; }
        public string minimum_nights { get; set; }
        public string maximum_nights { get; set; }
        public string cancellation_policy { get; set; }
        public DateTime last_scraped { get; set; }
        public DateTime calendar_last_scraped { get; set; }
        public int accommodates { get; set; }
        public int bedrooms { get; set; }
        public int beds { get; set; }
        public int number_of_reviews { get; set; }
        public int bathrooms { get; set; }
        public List<string> amenities { get; set; }
        public double price { get; set; }
        public double extra_people { get; set; }
        public int guests_included { get; set; }
        public Images images { get; set; }
        public Host host { get; set; }
        public Address address { get; set; }
        public Availability availability { get; set; }
        public ReviewScores review_scores { get; set; }
        public List<Review> reviews { get; set; }
    }