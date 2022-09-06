using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _118._Inheritance_Challenge___Videopost_and_Timer_with_Callback
{
    // ImagePost derives from post and adds a property (ImageURL) and two constructors
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            this.ID = GenNextID();
            this.Title = title;
            this.SenByUsername = sendByUsername;
            this.IsPublic = isPublic;
            // property ImageURL is a member of ImagePost, but not of Post
            this.ImageURL = imageURL;
        }
        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - by {this.SenByUsername} - image url : {this.ImageURL}");
        }
    }
}
