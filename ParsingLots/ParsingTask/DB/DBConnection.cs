using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingTask.DB
{
    public class DBConnection
    {
        public static void AddToDataBase(LotInfo lot)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Lots");
            var collection = database.GetCollection<LotInfo>("CollectionOfLots");
            collection.InsertOne(lot);
        }

        public static LotInfo FindByTitle(string title)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Lots");
            var collection = database.GetCollection<LotInfo>("CollectionOfLots");
            var lot = collection.Find(x => x.NumberOfLot == title).FirstOrDefault();
            return lot;
        }

        public static void SavingImageToDataBase(byte[] imageBytes, string lotTitle)
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
    }
}
