using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {

        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            //arrange
            var x = GetInt();
            //act
            SetInt(x);
            //assert
            Assert.Equal(3, x);
        }

        [Fact]
        public void ValueTypesCanPassByReference()
        {
            //arrange
            var x = GetInt();
            //act
            SetInt(ref x);
            //assert
            Assert.Equal(42, x);
        }

        private void SetInt(int x) { x = 42; }
        private void SetInt(ref int x) { x = 42; }
        private int GetInt() { return 3; }

        [Fact]
        public void GetBookReturnsUniqueNames()
        {
            //arrange
            var testBook1 = GetBook("Book 1");
            var testBook2 = GetBook("Book 2");
            //act
            //assert
            Assert.Equal("Book 1", testBook1.BookName);
            Assert.Equal("Book 2", testBook2.BookName);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            //arrange
            var testBook1 = GetBook("Book 1");
            //act
            SetName(testBook1, "New Name");
            //assert
            Assert.Equal("New Name", testBook1.BookName);
        }

        private void SetName(Book book, string newName)
        {
            book.BookName = newName;
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            //arrange
            var testBook1 = GetBook("Book 1");
            //act
            GetBookSetName(testBook1, "New Name");
            //assert
            Assert.Equal("Book 1", testBook1.BookName);
        }

        private void GetBookSetName(Book book, string newName)
        {
            book = new Book(newName);
        }

                [Fact]
        public void CSharpCanPassByReference()
        {
            //arrange
            var testBook1 = GetBook("Book 1");
            //act
            GetBookSetName(ref testBook1, "New Name");
            //assert
            Assert.Equal("New Name", testBook1.BookName);
        }

        private void GetBookSetName(ref Book book, string newName)
        {
            book = new Book(newName);
        }


        [Fact]
        public void DifferentBooksAreDifferentObjects()
        {
            //arrange
            var testBook1 = GetBook("Book 1");
            var testBook2 = GetBook("Book 2");
            //act
            //assert
            Assert.NotEqual(testBook1, testBook2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            //arrange
            var testBook1 = GetBook("Book 1");
            var testBook2 = testBook1;
            //act
            //assert
            Assert.Same(testBook1, testBook2);
        }

        [Fact]
        public void EquivalentValuesCanBeDifferent()
        {
            //arrange
            var testBook1 = GetBook("Book 1");
            var testBook2 = GetBook("Book 1");
            //act
            //assert
            Assert.Equal(testBook1.BookName, testBook2.BookName);
            Assert.NotEqual(testBook1, testBook2);
        }

        private Book GetBook(string v)
        {
            return new Book(v);
        }
    }
}
