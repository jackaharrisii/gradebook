using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        private string bookName;
        
        public Book(string name)
        {
            grades = new List<double>(){};
            this.bookName = name;
        }

        public Book()
        {
            grades = new List<double>(){};
            this.bookName = "unnamed";
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

        public void ShowStatistics(){
            System.Console.WriteLine($"The average grade is {AvgGrade():N1}");
            System.Console.WriteLine($"The highest grade is {HighGrade():N1}");
            System.Console.WriteLine($"The lowest grade is {LowGrade():N1}");
        }
    }
}