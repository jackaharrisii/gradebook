using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        public string BookName;
        
        public Book(string name)
        {
            grades = new List<double>(){};
            BookName = name;
        }

        public Book()
        {
            grades = new List<double>(){};
            BookName = "unnamed";
        }

        public void AddGrade(double newGrade){
            if (newGrade >= 0 && newGrade <= 100) grades.Add(newGrade);
            else System.Console.WriteLine($"The following grade is invalid: {newGrade}");
        }

        public double AvgGrade()
        {
            var sumGrades = 0.0;
            foreach(var num in grades) sumGrades += num;
            return sumGrades / grades.Count;
        }

        public double HighGrade()
        {
            var highGrade = double.MinValue;
            foreach(var num in grades) if (num > highGrade) highGrade = num;
            return highGrade;
        }

        public double LowGrade()
        {
            var lowGrade = double.MaxValue;
            foreach (var num in grades) if (num < lowGrade) lowGrade = num;
            return lowGrade;
        }

        public Statistics GetStatistics()
        {
            Statistics result = new Statistics();
            result.Average = AvgGrade();
            result.High = HighGrade();
            result.Low = LowGrade();

            return result;
        }

        public void ShowStatistics(Statistics stats){
            System.Console.WriteLine($"The average grade is {stats.Average}");
            System.Console.WriteLine($"The highest grade is {stats.High}");
            System.Console.WriteLine($"The lowest grade is {stats.Low}");
        }
    }
}