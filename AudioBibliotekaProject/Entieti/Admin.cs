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
    public class Admin : Member
    {
        public List<MongoDBRef> BooksApproved { get; set; }

        public Admin()
        {
            BooksApproved = new List<MongoDBRef>();
        }

        public void approveBook(AudioBook ab)
        {
            ab.Approved = true;
            ab.ApprovedBy = new MongoDBRef(this.GetType().ToString().ToLower(), this.Id);
            ab.Save();
            this.BooksApproved.Insert(0, new MongoDBRef("audiobook", ab.Id));
            this.GetCollection().Save(this);
        }
        public void removeUser(Member m)
        {
            var query = Query.EQ("_id", m.Id.ToString());
            mongoDB.GetCollection<Member>().Remove(query);
        }
        public void banUser(Member m, DateTime date)
        {
            m.BanedTill = date;
            mongoDB.GetCollection<Member>().Save(m);
        }

        public override MongoCollection GetCollection()
        {
            return mongoDB.GetCollection<Admin>();
        }
    }
}
