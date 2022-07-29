using System;

namespace _57._Enhanced_If_Statements___Ternary_Operator
{
    internal class Program
    {
        static int temperature = 2000;
        static string stateOfmatter;

        static void Main(string[] args)
        {
            StateCheckerVariation_1();
            Console.ReadKey();
        }

        public static void StateCheckerVariation_1()
        {
            if (temperature < 0)
            {
                stateOfmatter = "solid";
            }
            else if (temperature > 100)
            {
                stateOfmatter = "gas";
            }
            else { stateOfmatter = "liquid"; }
            Console.WriteLine("State of matter is {0}", stateOfmatter);
        }

        public static void StateCheckerVariation_2()
        /// this short but not recommended
        {
            if (temperature < 0){stateOfmatter = "solid";}
            else{stateOfmatter = "liquid";}
            Console.WriteLine("State of matter is {0}", stateOfmatter);
        }

        public static void StateCheckerVariation_3()
        {
            stateOfmatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of matter is {0}", stateOfmatter);
        }

    }
}
