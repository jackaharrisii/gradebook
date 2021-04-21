using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookShould
    {
        // [Fact]
        // public void ctor_nullary_empty()
        // {
        //     //Arrange
        //     var expectedGrades = new List<double>();
        //     var expectedBookName = "unnamed";
        //     //Act
        //     var testBook = new Book();
        //     //Assert
        //     Assert.Equal(expectedGrades, testBook.grades);
        //     Assert.Equal(expectedBookName, testBook.bookName);
        // }

        // [Fact]
        // public void ctor_NamedGradebook_hasName()
        // {
        //     //arrange
        //     var expectedGrades = new List<double>();
        //     var expectedBookName = "Test Gradebook";
        //     //act
        //     var testBook = new Book(expectedBookName);
        //     //assert
        //     Assert.Equal(expectedGrades, testBook.grades);
        //     Assert.Equal(expectedBookName, testBook.bookName);
        // }

        [Fact]
        public void Statistics_NamedGradebook_displaysStatistics()
        {
            //arrange
            var testBook = new Book();
            testBook.AddGrade(89.1);
            testBook.AddGrade(90.5);
            testBook.AddGrade(77.3);
            var expected = 85.6;
            //act
            var actual = testBook.AvgGrade();
            //assert
            Assert.Equal(expected, actual, 1);
        }

    }
}
