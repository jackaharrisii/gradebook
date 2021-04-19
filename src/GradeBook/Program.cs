using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new[] {12.7, 10.3, 6.11};
            var grades = new List<double>(){12.7, 10.3, 6.11, 4.1};
            grades.Add(56.1);

            var result = 0.0;
            foreach(var num in grades){
                result += num;
            }
            var avgGrade = result / grades.Count;
            //System.Console.WriteLine(result);
            System.Console.WriteLine($"The average grade is {avgGrade:N1}");

            if(args.Length > 0) 
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello... And who might you be?");
            }
        }
    }
}
