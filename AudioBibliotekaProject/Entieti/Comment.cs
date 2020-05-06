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
    public class Comment
    {
        public string Text { get; set; }
        public DateTime TimeCommented { get; set; }
        public MongoDBRef CommentedBy { get; set; }
    }
}
