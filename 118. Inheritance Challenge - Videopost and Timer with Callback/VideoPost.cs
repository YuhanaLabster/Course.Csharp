using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _118._Inheritance_Challenge___Videopost_and_Timer_with_Callback
{
    internal class VideoPost :Post
    {
        //member fields
        protected bool isPlaying = false;
        protected int currentDuration = 0;
        Timer timer;

        //properties
        protected string VideoUrl { get; set; }

        protected int Length { get; set; }

        public VideoPost() { }

        public VideoPost (string title, string sendByUsername, string VideoUrl,int Length)
        {
            this.ID = GenNextID();
            this.Title = title;
            this.SenByUsername = sendByUsername;
            this.VideoUrl = VideoUrl;
            this.Length = Length;
        }
        public override string ToString()
        {
            return String.Format($"{this.ID} - Title : {this.Title} - Send by Username {this.SenByUsername} Length {this.Length} - video url : {this.VideoUrl}   " );
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
            Console.WriteLine("is playing");
            timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }
        
        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying=false;
            Console.WriteLine($"stoped at {currentDuration}");
            currentDuration = 0;
            timer.Dispose();
            }
        }

        private void TimerCallback(Object o)
        {
            if(currentDuration < Length)
            {
                currentDuration++;
                Console.WriteLine($"video at {currentDuration}");
                GC.Collect();   
            }
            else
            {
                Stop();
            }
        }
    }
}

