using System;
using System.Collections.Generic;
using System.Linq;
//using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Hello! This is the grade book program.");

            GradeBook book = new GradeBook();
            book.Name = "Scott's grades book";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75f);

            GradeStatistics stats = book.ComputeStatistics();
            //Console.WriteLine("Average grade: " + stats.AverageGrade);
            //Console.WriteLine(stats.HighestGrade);
            //Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(book.Name);
            WriteResult("Average grade", stats.AverageGrade);
            WriteResult("Highest grade", (int)stats.HighestGrade);
            WriteResult("Lowest grade", stats.LowestGrade);

        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result)
        {
            //Console.WriteLine("{0}: {1:C} ", description, result);
            Console.WriteLine($"{description}: {result:F2} ");
        }
    }
}
