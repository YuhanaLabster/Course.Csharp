using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _161._Events_and_Multicast_Delegates
{
    class GameEventManager
    {
        //a new delegate type GameEvent
        public delegate void GameEvent();

        public static event GameEvent OnGameStart, OnGameOver;
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

        public static void TriggerGameStart()
        {
            // check if OnGameStart is not empty (no subscriptions from other class)
            // meaning that other methods already subs to it
            if (OnGameStart!= null)
            {
                Console.WriteLine("game has started");
                // call OnGameStart when all methods are subscribing
                OnGameStart();
            }
        }

        public static void TriggerGameOver()
        {
            // check if OnGameOver is not empty (no subscriptions from other class)
            // meaning that other methods already subs to it
            if (OnGameOver != null)
            {
                Console.WriteLine("game has finished");
                // call OnGameOver when all methods are subscribing
                OnGameOver();
            }
        }
    }
}
