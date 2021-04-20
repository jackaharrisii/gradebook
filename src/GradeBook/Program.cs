using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("My Gradebook");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(101);

            book.ShowStatistics();
        }
    }
}
