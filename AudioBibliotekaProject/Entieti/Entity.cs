using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace AudioBibliotekaProject.Entieti
{
    public abstract class Entity
    {
        public ObjectId Id { get; set; }
    }
}
