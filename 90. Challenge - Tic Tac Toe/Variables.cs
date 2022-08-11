using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _90._Challenge___Tic_Tac_Toe
{
    internal class Variables
    {
        public static string[,] Board =
        {
                { "1", "2", "3" },//[0, 0], [0, 1],[0, 2]
                { "4", "5", "6" },//[1, 0], [1, 1],[1, 2]
                { "7", "8", "9" },//[2, 0], [2, 1],[2, 2]
        };

        public static string Player1Character = "";
        public static string Player2Character = "";

    }
}
