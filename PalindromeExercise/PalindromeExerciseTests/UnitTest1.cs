using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", false)]
        [InlineData("hello", false)]
        [InlineData("Racecar", false)]
        public void MyTest(string word, bool expected)
        {
            //arrange
            var tester = new WordSmith();

            //act
            var actual = tester.IsAPalindrome(word);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
