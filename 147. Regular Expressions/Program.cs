using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace _147._Regular_Expressions
{
    internal class Program
    {
        static string Sample = "D:\\C#\\Learnerbly\\147. Regular Expressions\\Sample.txt";
        static string AssignmentFile = "D:\\C#\\Learnerbly\\147. Regular Expressions\\assignment.txt";
        static string Result;


        internal static int found;  
        static void Main(string[] args)
        {
            Assignment(StringConverter(FindMatches(ReadFilePerLine(AssignmentFile), "\\d{2,3}")));
        }

        static List<string> ReadFilePerLine(string filePath)
        {
            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines;
        }

        static List<string> FindMatches(List<string> inputs, string pattern)
        {
            Regex ItemRegex = new Regex(@pattern);
            List<string> matches = new List<string>();
            foreach (string input in inputs)
            {
                MatchCollection inputMatches = ItemRegex.Matches(input);

                foreach (Match match in inputMatches)
                {
                    matches.Add(match.Value);
                    found +=1;
                }
               
            }
            //Console.WriteLine((found == 0) ? "No Record Found" : $"{found} Record Found.");
            Console.Write($"from regex {matches}");
            return matches;

        }

        static List<int> StringConverter(List<string> input)
        {
            List<int> matches = new List<int>();
            foreach (var item in input)
            {
                int number;
                bool isParsable = Int32.TryParse(item, out number);
                matches.Add(number);
            }
            return matches;
        }

        static void Assignment(List<int> input)
        {
            foreach (int item in input)
            {
                char c = Convert.ToChar(item);
                Result += c;
                Console.Write(c);
            }
        }
    }
}


#region example of usage
/* 
find regex for this strings from Sample.txt
0175/12345678
+49165/12312347
0049165/12312347

My Answer : (.)+/\d{8}
Steps : 
(.)                 : to group all characters
+/                  : to add "/" into the filter
\d{8}               : if we check the lenght of the number after '/' is consistant 8, so defining the amount of lenght should be enough 

Course Answer : (\+49)|0049|0?1(6|7)\d/\d{8} 

===========================================================================================================================
find regex for this strings from Sample.txt
Mr. Panjuta
Mr Muller
Mr Robertson
Mr. G
Ms Smith
Ms Jackson

My answer : (Mr|Ms).+
Steps : 
(Mr|Ms).            : limiting to only Mr or Ms and make it as group by () then adding "." to capture the space
+                   : to capture the word after the space

===========================================================================================================================
find regex for this strings from Sample.txt
https://www.tutorials.eu
https://tutorials.eu
http://www.tutorials.eu
http://tutorials.eu 

My Answer : (http://|https://).+
Steps : 
(http://|https://)  : Find the first pattern either "http://" or "http://" then group it
.+                  : to get all characters after the first pattern

from course : https?://(www.)?(\w+)(\.\w+)

 */
#endregion