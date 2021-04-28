using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookShould
    {

        [Fact]
        public void Statistics_Gradebook_getsAverage()
        {
            //arrange
            var testBook = new Book();
            testBook.AddGrade(89.1);
            testBook.AddGrade(90.5);
            testBook.AddGrade(77.3);
            var expected = 85.6;
            //act
            var actual = testBook.GetStatistics();
            //assert
            Assert.Equal(expected, actual.Average, 1);
        }

        [Fact]
        public void Statistics_Gradebook_getsHigh()
        {
            //arrange
            var testBook = new Book();
            testBook.AddGrade(89.1);
            testBook.AddGrade(90.5);
            testBook.AddGrade(77.3);
            var expected = 90.5;
            //act
            var actual = testBook.GetStatistics();
            //assert
            Assert.Equal(expected, actual.High, 1);
        }

        [Fact]
        public void Statistics_Gradebook_getsLow()
        {
            //arrange
            var testBook = new Book();
            testBook.AddGrade(89.1);
            testBook.AddGrade(90.5);
            testBook.AddGrade(77.3);
            var expected = 77.3;
            //act
            var actual = testBook.GetStatistics();
            //assert
            Assert.Equal(expected, actual.Low, 1);

        }

    }
}
