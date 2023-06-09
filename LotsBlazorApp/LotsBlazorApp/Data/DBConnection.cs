using MongoDB.Bson;
using MongoDB.Driver.GridFS;
using MongoDB.Driver;

namespace LotsBlazorApp.Data
{
    public class DBConnection
    {
        public void AddToDataBase(LotInfo lot)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Lots");
            var collection = database.GetCollection<LotInfo>("CollectionOfLots");
            collection.InsertOne(lot);
        }

        public LotInfo FindByTitle(string title)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Lots");
            var collection = database.GetCollection<LotInfo>("CollectionOfLots");
            var lot = collection.Find(x => x.NumberOfLot == title).FirstOrDefault();
            return lot;
        }

        public void SavingImageToDataBase(byte[] imageBytes, string lotTitle)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("LotsImages");
            var gridFSBucket = new GridFSBucket(database);
            // Сохранение изображения в базу данных
            var id = ObjectId.GenerateNewId();
            var options = new GridFSUploadOptions
            {
                Metadata = new BsonDocument
                        {
                            { "filename", lotTitle }
                        }
            };
            using (var stream = new MemoryStream(imageBytes))
            {
                gridFSBucket.UploadFromStream(id, lotTitle, stream, options);
            }
        }

        public List<LotInfo> ImportAllLots()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Lots");
            var collection = database.GetCollection<LotInfo>("CollectionOfLots");
            var list = collection.Find(new BsonDocument()).ToList();
            return list;
        }
    }
}
