using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<String> testList = new List<string>();
            //testList.Add("Hello");
            //testList.Add("World");
            //testList.Add("Hello");
            //testList.Add("Whatever");
            //DuplicateRemover duplicateRemover = new DuplicateRemover();
            //List<String> alteredList = duplicateRemover.RemoveDuplicates(testList);
            //foreach (string entry in alteredList)
            //{
            //    Console.WriteLine(entry);
            //}
            //List<String> grades = new List<string>();
            //grades.Add("100,90,85,50");
            //grades.Add("80,70,60,50");
            //grades.Add("30,100,60,20,100");
            //GradeAverager gradeAverager = new GradeAverager();
            //double answer = gradeAverager.AverageGrades(grades);
            //Console.WriteLine(answer);
            LetterFrequency letterFrequency = new LetterFrequency();
            string testString = "uehwnbsalopzmcq";
            Console.WriteLine(letterFrequency.GetFrequencies(testString));
            Console.ReadKey();
        }
    }
}
