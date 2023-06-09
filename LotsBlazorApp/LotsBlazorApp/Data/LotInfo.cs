using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace LotsBlazorApp.Data
{
    public class LotInfo
    {
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        public string NumberOfLot { get; set; }
        public string Title { get; set; }
        public string StartingPrice { get; set; }
        public string AuctionStep { get; set; }
        public string LotType { get; set; }
        public string LotSub { get; set; }
        public string LotDescription { get; set; }
        public string LocationSubject { get; set; }
        public string Location { get; set; }
        public string ObjectCategory { get; set; }
        public string OwnershipForm { get; set; }
        public string LandPurpose { get; set; }
        public string? ImageUrl { get; set; }
    }
}
