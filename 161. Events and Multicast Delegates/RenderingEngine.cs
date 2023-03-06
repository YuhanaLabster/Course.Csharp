using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _161._Events_and_Multicast_Delegates
{
    public class RenderingEngine
    {
        // ----------------------------------------------- START : WITH multicast -----------------------------------------------

        // in order to use multicasr delegate we need to create constractor to
        // subscibe to GameEventManager
        public RenderingEngine()
        {
            // subscribe to OnGameStart, the += means we subscibe to GameEventManager.XXXX
            GameEventManager.OnGameStart += StartGame;
            // subscribe to OnGameOver , the += means we subscibe to GameEventManager.XXXX
            GameEventManager.OnGameOver += GameOver;
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
        }
        // ----------------------------------------------- END : WITH multicast -----------------------------------------------

        // at the start of the game,
        // we want to enable the rendering engine and start drawing the visuals
        private void StartGame()
        // when using mulicast delegate we're no longer need to make the method in public
        {
            Console.WriteLine("Render process started");
        }
        //when the game is over, we want to stop our rendering engine
        private void GameOver()
        // when using mulicast delegate we're no longer need to make the method in public
        {
            Console.WriteLine("Render process Finished");
        }
    }
}
