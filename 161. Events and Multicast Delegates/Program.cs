using System;

namespace _161._Events_and_Multicast_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an audio system
            AudioSystem audioSystem= new AudioSystem();

            // create an renderingEngine system
            RenderingEngine renderingEngine = new RenderingEngine();

            //create players for the game : 
            Player player1 = new Player("qontol");
            Player player2 = new Player("memegs");
            Player player3 = new Player("jembuts");
            Player player4 = new Player("lakangs");

            // ----------------------------------------------- START : WITHOUT multicast -----------------------------------------------

            //// start the audio and rendering
            //audioSystem.StartGame();
            //renderingEngine.StartGame();

            ////spawn the player
            //player1.StartGame();
            //player2.StartGame();

            //// notify when the game is running
            //Console.WriteLine("game is running, press any key to close the game");
            //Console.ReadLine();

            //audioSystem.GameOver();
            //renderingEngine.GameOver();

            //player1.GameOver();
            //player2.GameOver();
            //Console.WriteLine("game is successfully stopped");
            // ----------------------------------------------- END : WITHOUT multicast -----------------------------------------------


            // ----------------------------------------------- START : WITH multicast -----------------------------------------------
            GameEventManager.TriggerGameStart();
            Console.WriteLine("press any key to stop it");
            Console.ReadLine();
            GameEventManager.TriggerGameOver();
            // ----------------------------------------------- END : WITH multicast -----------------------------------------------



        }
    }
}
