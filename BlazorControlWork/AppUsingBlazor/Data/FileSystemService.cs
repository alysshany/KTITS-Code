﻿using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using MongoDB.Bson;
using Microsoft.AspNetCore.Components.Forms;

namespace AppUsingBlazor.Data
{
    public class FileSystemService
    {
        public void UploadImageToDb(string file, string path)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("GalievaZ");
            var gridFS = new GridFSBucket(database);

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                gridFS.UploadFromStream(file, fs);
            }
        }

        public void UploadImagesToDbFromProject()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("GalievaZ");
            var gridFS = new GridFSBucket(database);
            foreach (var file in Directory.GetFiles("wwwroot/Images"))
            {
                if (FindFile(Path.GetFileName(file)) == null)
                {
                    UploadImageToDb(Path.GetFileName(file), file);
                }
            }
        }

        public async Task UploadImageToDb(Stream stream, string fileName)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("GalievaZ");
            var gridFS = new GridFSBucket(database); 
            await gridFS.UploadFromStreamAsync(fileName, stream);
        }

        public List<string> FindFiles()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("GalievaZ");
            var gridFS = new GridFSBucket(database);
            var fileIn = gridFS.Find(new BsonDocument()).ToList();
            var imageIn = new List<string>();
            foreach (var file in fileIn)
            {
                imageIn.Add(file.Filename);
            }
            return imageIn;
        }

        public void DownloadFileToProject(IBrowserFile file)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("GalievaZ");
            var gridFS = new GridFSBucket(database);

            try
            {
                using (FileStream fs = new FileStream($"{Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/wwwroot/images/")}{file.Name}", FileMode.CreateNew))
                {
                    gridFS.DownloadToStreamByName(file.Name, fs);
                }
            }
            catch (Exception)
            {

            }
        }

        public GridFSFileInfo FindFile(string filename)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("GalievaZ");
            var gridFS = new GridFSBucket(database);
            return gridFS.Find(Builders<GridFSFileInfo>.Filter.Eq(x => x.Filename, filename)).FirstOrDefault();
        }

        public List<string> UploadImg()
        {
            UploadImagesToDbFromProject();

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("GalievaZ");
            var gridFS = new GridFSBucket(database);
            var files = gridFS.Find(new BsonDocument()).ToList();
            var images = new List<string>();
            foreach (var file in files)
            {
                images.Add(file.Filename);
            }
            return images;
        }
    }
}
