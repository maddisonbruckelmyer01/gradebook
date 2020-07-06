using System;
using System.Net;
using Xunit;

namespace test
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            //arrage - where you put together all your test data and you arrange the objects and values you are going to use
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
            //act - invoke a method to perform a computation or perform a calculation " you actually do something that produces a result, the actual result "

            var result = book.GetStatistics();
            //assert - where you assert something about the value that was computed inside of act  
            Assert.Equal(85.6, result.Average);
            Assert.Equal(90.5, result.High);
            Assert.Equal(77.3, result.Low);
        }
    }
}
