using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQStatements
{
    class GradeAverager
    {
        public double AverageGrades(List<String> grades)
        {
            // Write a function that calculates the class grade average after dropping the lowest grade for each student.
            // That is: Write a function that takes in a list of strings of grades (e.g., one string might be "90,100,82,89,55")
            //, drops the lowest grade from each string, averages the rest of the grades from that string, then averages the
            //averages.
            List<double> averages = new List<double>();
            foreach (string element in grades)
            {
                List<double> doubleGrades = new List<double>();
                var gradesToInteger = element.Split(new[] {','}).ToList();
                foreach (string elem in gradesToInteger)
                {
                    doubleGrades.Add(Convert.ToDouble(elem));
                }
                var minimumGrade = (from d in doubleGrades select d).Min();
                doubleGrades.Remove(minimumGrade);
                double totalGrades = (from d in doubleGrades select d).Sum();
                double numberOfGrades = (from d in doubleGrades select d).Count();
                double average = totalGrades / numberOfGrades;
                averages.Add(average);

            }
            double averageTotal = (from d in averages select d).Sum();
            double numberOfAverages = (from d in averages select d).Count();
            return averageTotal / numberOfAverages;
        }
    }
}
