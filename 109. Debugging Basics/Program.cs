using System;
using System.Collections.Generic;

namespace _109._Debugging_Basics
{
    internal class Program
    {
        public static List<string> friends = new List<string> { "Frank","Joe","Michelle","Andy","Maria","Carlos", "Angelina"};
        public static List<string> partyFriends = GetPartyFriends(friends, 3);

        static void Main(string[] args)
        {
            DisplayPartyFriends();
        }

        public static void DisplayPartyFriends()
        {
            foreach (var name in partyFriends)
            {
                Console.WriteLine(name);
            }
        }
        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            var partyFriends = new List<string>();

            while (partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriend(list);
                partyFriends.Add(currentFriend);
                list.Remove(currentFriend);
            }
            return partyFriends;
        }

        public static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if  (list[i].Length > shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
            return shortestName;
        }

    }
}

/* BUG : Incorrect output, should find the shortest but showing the opposite (longer name) 
    * line of issue : in GetPartyFriend function in : list[i].Length > shortestName.Length
    * fix           : replace '>' with '<' as we need to find the shortest name
    * 
    * Debugging Steps : 
        * using break points
 * 
 */
