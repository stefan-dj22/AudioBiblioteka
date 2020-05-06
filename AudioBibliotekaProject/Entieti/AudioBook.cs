using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System.Drawing;

namespace AudioBibliotekaProject.Entieti
{
    public class AudioBook : Entity
    {
        public MongoDBRef Cover { get; set; }
        public MongoDBRef Book { get; set; }
        public string Descripiton { get; set; }
        public string Name { get; set; }
        public string Author { get; set; } 
        public string Naraor { get; set; }

        public DateTime DateUpdated { get; set; }
        public MongoDBRef UpdatedBy { get; set; }
        public MongoDBRef ApprovedBy { get; set; }
        public AudioBook() { }
        public bool Approved { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Review> NaratorReview { get; set; }
        public List<Review> BookReview { get; set; }
        public Rate Rating { get; set; }

        public void Init()
        {
            Comments = new List<Comment>();
            NaratorReview = new List<Review>();
            BookReview = new List<Review>();
            Rating = new Rate();
            DateUpdated = DateTime.Now;
        }
        public AudioBook( string name, string author)
        {
            Init();
            this.Name = name;
            this.Author = author;
        }
        public void setCover(string path)
        {
            if (Cover != null)
                mongoDB.DB.GridFS.DeleteById(Cover.Id);
            this.Cover = new MongoDBRef("fs.files", mongoDB.updateFile(path));
        }
        public void setBook(string path)
        {
            if (Cover != null)
                mongoDB.DB.GridFS.DeleteById(Book.Id);
            this.Book = new MongoDBRef("fs.files", mongoDB.updateFile(path));
        }
        public void setDescription(string desc)
        {
            this.Descripiton = desc;
        }
        public void setNarator (string narator)
        {
            this.Naraor = narator;
        }
        public void Save()
        {
            mongoDB.GetCollection<AudioBook>().Save(this);
        }
        public void Delete()
        {
            if(Cover!=null)
                mongoDB.DB.GridFS.DeleteById(Cover.Id);
            if(Book!=null)
                mongoDB.DB.GridFS.DeleteById(Book.Id);
            var query = Query.EQ("_id", Id.ToString());
            mongoDB.GetCollection<AudioBook>().Remove(query);
        }
        public void Download(string path)
        {
            mongoDB.downloadFile(path, this.Id);
        }
        public Image getImg()
        {
            var file = mongoDB.DB.GridFS.FindOne(Query.EQ("_id", Cover.Id));
            using (var stream = file.OpenRead())
            {
                return Image.FromStream(stream);

            }
        }
    }
}