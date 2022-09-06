using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _118._Inheritance_Challenge___Videopost_and_Timer_with_Callback
{
    internal class Post
    {
        private static int currentPostId;


        // Properties
        protected int ID { get; set; }

        protected string Title { get; set; }

        protected string SenByUsername { get; set; }

        protected bool IsPublic { get; set; }

        // Default constructor, if derived class doesn't invoke a base-class constructor explicitly, the default constractor will called implicitly

        public Post()
        {
            ID = 0;
            Title = "My first post";
            IsPublic = true;
            SenByUsername = "Yuhana";
        }

        // instance constructor that has three parameters

        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GenNextID();
            this.Title = title;
            this.SenByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GenNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }
        // virtua method override of ToString method that is inherited
        // from System.Object
        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - by {this.SenByUsername}");
        }
    }
}
