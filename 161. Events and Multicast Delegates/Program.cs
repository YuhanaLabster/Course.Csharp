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

            // --------------- introducing EVENT --------------- 
            // why we need an event? because the common issue is we're sometime assign the method BUT NOT SUBSCRIBING TO IT
            // EXAMPLE : "+= StartGame;" is CORRECT as its subscribing, but `= StartGame`; is wrong, its assining not subscribing!
            // the IDE won't give an error when we do that, that's why we need an "event" to secure it
            // by this way we wont make mistake to subscribe it
            // how to do that? we will add 'event' before in GameEvent method
            // from public static GameEvent OnGameStart, OnGameOver;
            // to public event static GameEvent OnGameStart, OnGameOver;
            // by this way when we do `= StartGame` IDE will throw an error : 
            // "The event 'GameEventManager.OnGameStart' can only appear on the left hand side of += or -=
            // (except when used from within the type 'GameEventManager')

            // --------------------------- KEY POINTS ---------------------------
            // EVENT are forced to behave like a list : 
            // "+=" to subscribe or "-=" to unsubscribe are allowed but "=" not allowed
            // Delegates allow a direct assignment : myDelegate = myMethod
            // EVENT can not be triggered from outside the class that defines them
        }
    }
}
