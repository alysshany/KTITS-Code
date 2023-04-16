﻿using MongoDB.Driver;

namespace AppUsingBlazor.Data
{
    public class DBConnection
    {
        public static void AddToDataBase(User user)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Galieva");
            var collection = database.GetCollection<User>("CollectionOfUsers");
            collection.InsertOne(user);
        }

        public static async Task<User> FindByLoginAsync(string login)
        {
            await Task.Delay(4000);
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Galieva");
            var collection = database.GetCollection<User>("CollectionOfUsers");
            var user = collection.Find(x => x.Login == login).FirstOrDefault();

            return user;
        }
    }
}