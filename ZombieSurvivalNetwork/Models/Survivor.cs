using MongoDB.Bson.Serialization.Attributes;

namespace ZombieSurvivalNetwork.Models
{
    public class Survivor
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
    }
}
