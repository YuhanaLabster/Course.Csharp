using System;
using System.Linq;
using System.Collections.Generic;

namespace _197._Sorting_and_Filtering_with_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            um.FemaleStudents();
            um.TransGenderStudents();
            um.SortByStudentAge();
            um.StudentFromUniversity(1);

            // -------------- another Linq function -------------- 
            int[] someInt = { 30, 25, 21, 69, 80, 1, 60 };
            IEnumerable<int> ascendingSortyByLinq = from i in someInt orderby i select i;
            IEnumerable<int> descendingsortyByLinq = from i in someInt orderby i descending select i;
            // or we can do this way
            IEnumerable<int> reversingAscendingSortyByLinq = ascendingSortyByLinq.Reverse();

            Console.WriteLine("ascendingSortyByLinq");
            foreach (int i in ascendingSortyByLinq)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("descendingsortyByLinq");
            foreach (int i in descendingsortyByLinq)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("reversingAscendingSortyByLinq");
            foreach (int i in reversingAscendingSortyByLinq)
            {
                Console.WriteLine(i);
            }
        }
    }
}
