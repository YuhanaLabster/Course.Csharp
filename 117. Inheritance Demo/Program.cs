using System;

namespace _117._Inheritance_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post("thanks!",true, "yuhana");
            Console.WriteLine(post.ToString());
            ImagePost imagePost1 = new ImagePost("check my webs","yuhana","https://test/com",true);
            Console.WriteLine(imagePost1.ToString());
        }
    }
}
