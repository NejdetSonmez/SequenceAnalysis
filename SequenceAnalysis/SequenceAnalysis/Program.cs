using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceAnalysis
{
    class Program
    {
        static void SequenceAnalysis(string sentences)
        {
            var result = new List<char>();
            char[] cString = sentences.ToCharArray();
            Array.Sort(cString);
            foreach (char s in cString)
            {
                if (char.IsUpper(s))
                {
                    result.Add(s);
                }
            }
            Console.Write("Output: ");
            result.ForEach(_s =>Console.Write(_s));
        }
        static void Main(string[] args)
        {
            string inputString;
            Console.WriteLine("Welcome to SequenceAnalysis! Please, enter a sentence.");
            Console.Write("Input: ");
            inputString = Console.ReadLine();
            SequenceAnalysis(inputString);
            Console.ReadKey();
        }

    }
}
