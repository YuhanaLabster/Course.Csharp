using System;

namespace _87._Multi_Dimensional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2D array with singgle comma inside the square bracket "[]"
            int[,] array2D = new int[,]
            {
             // coloumn 0  | coloumn 1 |    index 2
                {1,             2,             3}, // row 0
                {4,             5,             6}, // row 1
                {7,             8,             9}  // row 2  
            };
            Console.WriteLine(array2D[2,0]); //to access number 7 we defined call the row then the coloumn


            string[,,] array3D = new string[,,]
            {
                { 
                    //  This is array 0, started with 0 at first index [0,0,0]
                    // coloumn 0  |   coloumn 1
                    {"Hi"       ,   "hello" },  // row 0 
                    {"what"     ,   "wow"   },  // row 1
                    { "you"     ,   "good"  }   // row 2
                },
                    //  This is array 1, started with 1 at first index [1,0,0]
                    // coloumn 0  |   coloumn 1
                {
                    {"white"    ,   "blue"  },  // row 0
                    {"yellow"   ,   "red"   },  // row 1
                    {"grey"     ,   "black" }   // row 2
                }
            };
            Console.WriteLine(array3D[1,2,0]);
            /* 
             * To access "red" : check the array number (1), and then check the row (1), then the coloumn (1) so it would be 1,1,1
             * To access "wow" : check the array number (0), and then check the row (1), then the coloumn (1) so it would be 0,1,1
             * To access "grey" : check the array number (1), and then check the row (2), then the coloumn (0) so it would be 0,1,1
             * 
            */
                                   // specifier below separated by comma
            string[,] array2dTest = new string[3, 2] { {"1","2"}, {"3","4"}, {"5","6"} }; //it means : 3 row, and each row has 2 entries

            string [,] arrayTest =  new string[3, 2] { { "1","2"}, { "3","4"}, { "5","6"} };

            arrayTest[1, 1] = "replaced";
            Console.WriteLine(arrayTest[0,1]);
        }

    }
}
