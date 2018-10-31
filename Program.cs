using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook book = CreateGradeBook();
            //GradeBook book = new GradeBook();

            //GetBookName(book);
            AddGrades(book);
            SaveGrades(book);
            WriteResults(book);

        }

        private static GradeBook CreateGradeBook()
        {
            return new ThrowAwayGradeBook();
        }

        private static void WriteResults(GradeBook book)
        {
            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average grade", stats.AverageGrade);
            WriteResult("Highest grade", stats.HighestGrade);
            WriteResult("Lowest grade", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        private static void SaveGrades(GradeBook book)
        {
            using (StreamWriter outputFile = File.CreateText("Grades.txt"))
            {
                book.WriteGrades(outputFile);
            }
        }

        private static void AddGrades(GradeBook book)
        {
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75f);
        }

        private static void GetBookName(GradeBook book)
        {
            try
            {
                Console.WriteLine("Enter a name: ");
                book.Name = Console.ReadLine();
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine("Something went wrong");
            }
        }

        static void WriteResult(string description, float result)
        {
            //Console.WriteLine("{0}: {1:C} ", description, result);
            Console.WriteLine($"{description}: {result:F2} ");
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result} ");
        }
    }
}
