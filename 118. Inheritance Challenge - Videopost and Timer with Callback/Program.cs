using System;

namespace _118._Inheritance_Challenge___Videopost_and_Timer_with_Callback
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post("thanks!", true, "yuhana");
            Console.WriteLine(post.ToString());
            ImagePost imagePost1 = new ImagePost("check my webs", "yuhana", "https://test/com", true);
            Console.WriteLine(imagePost1.ToString());
            VideoPost videoPost1 = new VideoPost("testing","yuhana","https://youtube.com", 5);
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("press anykey to stop the video");
            Console.ReadKey();
            videoPost1.Stop();
        }
    }
}
/*
CHALLENGE add a deriving Class "VideoPost" with a property VideoURL,
create the required constructors to create a VideoPost
adjust the ToString() method accordingly
create an instance of VideoPost and use the ToString method on it.
use Timer and a Callback method here (google it : ) )
More advanced -
create fields as required
Length .
add member methods "Play" which should write the current duration of the video
and "Stop" which should stop the "timer" and write "stopped at {e}s" onto the console.
Play the video after creating the instance and pause it, when the user presses any key
*/
