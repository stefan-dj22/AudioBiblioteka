using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System.Drawing;
using System.IO;
namespace AudioBibliotekaProject.Entieti
{
    public class Member : Entity
    {

        public string Username { get; set; }
        public byte[] Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Rate Rating { get; set; }
        public Inbox userInbox { get; set; }
        public DateTime TimeRegistred { get; set; }
        public DateTime BanedTill { get; set; }


        public MongoDBRef UserImg { get; set; }
        public List<MongoDBRef> RatedAB { get; set; }
        public List<MongoDBRef> RatedUsers { get; set; }
        public List<MongoDBRef> ReviewdAB { get; set; }
        public List<MongoDBRef> CommentedAB { get; set; }
        public List<MongoDBRef> UpdatedBook { get; set; }

        public Member()
        {

            RatedAB = new List<MongoDBRef>();
            ReviewdAB = new List<MongoDBRef>(); 
            CommentedAB = new List<MongoDBRef>();
            RatedUsers = new List<MongoDBRef>();
            UpdatedBook = new List<MongoDBRef>();
            userInbox = new Inbox();
            
            Rating = new Rate();
            Rating.Likes = 0;
            Rating.Dislikes = 0;
            Name = "";
            Surname = "";
        }

        #region staticFunctions
        public static Member getByUsername(string username)
        {
            var query = Query.EQ("Username", username);
            Member mem = mongoDB.GetCollection<Member>().FindOne(query);
            if (mem == null) 
                mem= mongoDB.GetCollection<Admin>().FindOne(query);
            return mem;
        }
        public static Member LogIn(string un, string pass)
        {
            Member tmp = Member.getByUsername(un);
            if (tmp == null)
                return null;
            PasswordHash hash = new PasswordHash( tmp.Password);
            if (!hash.Verify(pass))
                return null;
            return tmp;
        }

#endregion


        public bool register(string username, string password)
        {
            if (Member.getByUsername(username) != null)
                return false;
            Username = username;
            PasswordHash hash = new PasswordHash(password);
            Password = hash.ToArray();
            TimeRegistred = DateTime.Now;
            this.GetCollection().Insert(this);
            return true;
        }



        public void updateImg(string path)
        {
            if (UserImg != null)
                mongoDB.DB.GridFS.DeleteById(UserImg.Id);
            this.UserImg = new MongoDBRef("fs.files", mongoDB.updateFile(path));
            this.GetCollection().Save(this);
        }
        public Image getImg()
        {
            var file = mongoDB.DB.GridFS.FindOne(Query.EQ("_id", UserImg.Id));
            using(var stream = file.OpenRead())
            {
                return Image.FromStream(stream);

            }
        }


        public bool isBanned()
        {
            if (BanedTill == null)
                return false;
            if (DateTime.Compare(BanedTill, DateTime.Now) > 0)
                return true;
            return false;
        }

        
        public void updateInfo(string Name, string Surname) {
            this.Name = Name;
            this.Surname = Surname;
            var query = Query.EQ("_id", this.Id);
            var update = Update.Set("UName", BsonValue.Create(Name)).Set("Surname", Surname);
            this.GetCollection().Update(query, update);
        }
        public virtual MongoCollection GetCollection()
        {
            return mongoDB.GetCollection<Member>();
        }


        public void SendMsg<T>( ObjectId recv, string msg,MongoDBRef file=null) where T : Member
        {
            Type t = this.GetType();
            Message nMsg = new Message();
            nMsg.TimeCreated = DateTime.Now;
            nMsg.Content = msg;
            nMsg.Sender = new MongoDBRef(t.ToString().ToLower(), this.Id);
            nMsg.Reciver = new MongoDBRef(typeof(T).Name.ToLower(), recv);
            if (file != null)
                nMsg.File = file;
            this.userInbox.Sent.Insert(0, nMsg);
           
           
            var senderCollection = this.GetCollection();
            senderCollection.Save(this);

            
            var recvCollection = mongoDB.GetCollection<T>();
            Member reciver = recvCollection.FindOneById(recv);
            reciver.userInbox.Recived.Insert(0, nMsg);
            recvCollection.Save(reciver);
        }
        public void updateBook(string description, string bookPath, string imgPath,string Name, string Author, string Narator)
        {
            AudioBook ab = new AudioBook(Name,Author);
            ab.setBook(bookPath);
            if (imgPath != null)
                ab.setCover(imgPath);
            if (Narator != null)
                ab.setNarator(Narator);
            if (description != null)
                ab.setDescription(description);
            ab.UpdatedBy = new MongoDBRef(this.GetType().ToString().ToLower(), this.Id);
            ab.Save();

            this.UpdatedBook.Add(new MongoDBRef("audiobook", ab.Id));
            this.GetCollection().Save(this);

        }

        public bool rateUser(Member mem,bool upVote)
        {
            bool voted=false;
            foreach (MongoDBRef refId in this.RatedUsers)
                if (refId.Id == mem.Id)
                    voted = true;
            if (voted)
                return false;
            if (upVote)
                mem.Rating.Likes++;
            else
                mem.Rating.Dislikes++;
            mem.GetCollection().Save(mem);
            this.RatedUsers.Insert(0, new MongoDBRef(mem.GetType().ToString().ToLower(), mem.Id));
            this.GetCollection().Save(this);
            return true;
        }
        public bool rateAB(AudioBook ab, bool upVote)
        {

            if (isRatedBook(ab))
                return false;
            if (upVote)
                ab.Rating.Likes++;
            else
                ab.Rating.Dislikes++;
            mongoDB.GetCollection<AudioBook>().Save(ab);
            this.RatedAB.Insert(0, new MongoDBRef(ab.GetType().ToString().ToLower(), ab.Id));
            this.GetCollection().Save(this);
            return true;
        }
        public bool reviewBook(AudioBook ab, string Text, int Rate)
        {
            if (this.isReviewBook(ab))
                return false;
            Review r = new Review();
            r.DateReviewd = DateTime.Now;
            r.ReviewedBy = new MongoDBRef(this.GetType().ToString().ToLower(), this.Id);
            if (Text != null)
                r.Explanation = Text;
            r.Rating = Rate;
            ab.BookReview.Insert(0, r);
            mongoDB.GetCollection<AudioBook>().Save(ab);
            this.ReviewdAB.Insert(0, new MongoDBRef(ab.GetType().ToString().ToLower(), ab.Id));
            this.GetCollection().Save(this);
            return true;
        }
        public bool reviewNarator(AudioBook ab, string Text, int Rate)
        {
            if (isReviewNarator(ab))
                return false;
            Review r = new Review();
            r.DateReviewd = DateTime.Now;
            r.ReviewedBy = new MongoDBRef(this.GetType().ToString().ToLower(), this.Id);
            if (Text != null)
                r.Explanation = Text;
            r.Rating = Rate;
            ab.NaratorReview.Insert(0, r);
            mongoDB.GetCollection<AudioBook>().Save(ab);
            this.ReviewdAB.Insert(0, new MongoDBRef(ab.GetType().ToString().ToLower(), ab.Id));
            this.GetCollection().Save(this);
            return true;
        }
        public bool coomentBook(AudioBook ab, string Text)
        {
            bool reviewed = false;
            foreach (MongoDBRef refId in this.ReviewdAB)
                if (refId.Id == ab.Id)
                    reviewed = true;
            if (reviewed)
                return false;
            Comment c = new Comment();
            c.TimeCommented = DateTime.Now;
            c.CommentedBy= new MongoDBRef(this.GetType().ToString().ToLower(), this.Id);
            c.Text= Text;
            ab.Comments.Insert(0, c);
            mongoDB.GetCollection<AudioBook>().Save(ab);
            this.ReviewdAB.Insert(0, new MongoDBRef(ab.GetType().ToString().ToLower(), ab.Id));
            this.GetCollection().Save(this);
            return true;
        }
        public bool isReviewBook(AudioBook ab)
        {
            bool reviewed = false;
            foreach (MongoDBRef refId in this.ReviewdAB)
                if (refId.Id == ab.Id)
                    reviewed = true;
            return reviewed;
        }
        public bool isRatedBook(AudioBook ab)
        {
            bool voted = false;
            foreach (MongoDBRef refId in this.RatedAB)
                if (refId.Id == ab.Id)
                    voted = true;
            return voted;
        }
        public bool isReviewNarator(AudioBook ab)
        {
            bool reviewed = false;
            foreach (MongoDBRef refId in this.ReviewdAB)
                if (refId.Id == ab.Id)
                    reviewed = true;
            return reviewed;
        }
        


    }
}
