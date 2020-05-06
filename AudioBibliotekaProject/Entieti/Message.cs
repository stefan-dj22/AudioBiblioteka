using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace AudioBibliotekaProject.Entieti
{
    public class Message:Entity
    {
        public MongoDBRef Sender { get; set; }
        public MongoDBRef Reciver { get; set; }
        public string Content { get; set; }
        public bool Readed { get; set; }
        public MongoDBRef File { get; set; }
        public DateTime TimeCreated { get; set; }


    }
}
