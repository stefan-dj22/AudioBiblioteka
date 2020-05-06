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
    public class Review
    {
        public string Explanation {get; set;}
        private int _rating;
        public int Rating { get { return _rating; } set { if (value > 10 || value < 1) return; } }
        public DateTime DateReviewd { get; set; }
        public MongoDBRef ReviewedBy { get; set; }
    }
}
