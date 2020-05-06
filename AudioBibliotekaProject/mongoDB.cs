using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.GridFS;
using System.IO;
using AudioBibliotekaProject.Entieti;

namespace AudioBibliotekaProject
{
    public static class mongoDB
    {
        private static string connectionString = "mongodb://localhost/?safe=true";
        public static string DatabaseName { get { return "AudioLibary"; } }

        private static MongoServer _server;
        private static MongoDatabase _database;

        public static MongoServer Server
        {
            get
            {
                if (_server == null)
                {
                    _server = MongoServer.Create(connectionString);
                }

                return _server;
            }
        }

        public static MongoDatabase DB
        {
            get
            {
                if (_database == null)
                    _database = Server.GetDatabase(mongoDB.DatabaseName);

                return _database;
            }
        }

        public static MongoCollection<T> GetCollection<T>() where T : Entity
        {
            return DB.GetCollection<T>(typeof(T).Name.ToLower());
        }

        public static List<T> GetEntityList<T>() where T : Entity
        {
            var collection = mongoDB.DB.GetCollection<T>(typeof(T).Name.ToLower());
            return collection.FindAll().ToList<T>();
        }

        public static void InsertEntity<T>(T entity) where T : Entity
        {
            GetCollection<T>().Save(entity);
            
        }
        public static  ObjectId updateFile(string path)//greska picTo JSON
        {

            using (var fs = new FileStream(path, FileMode.Open))
            {
                var gridFsInfo = mongoDB.DB.GridFS.Upload(fs, Path.GetFileName(path));
                var fileId = gridFsInfo.Id;
                return fileId.AsObjectId;

            }
        }
        public static void downloadFile(string path,ObjectId id)
        {
            var file = DB.GridFS.FindOneById(id.ToBson());
            
            using (var stream = file.OpenRead())
            {
                var bytes = new byte[stream.Length];
                stream.Read(bytes, 0, (int)stream.Length);
                using (var newFs = new FileStream(path+file.Name, FileMode.Create))
                {
                    newFs.Write(bytes, 0, bytes.Length);
                }
            }
        }
    }
}
