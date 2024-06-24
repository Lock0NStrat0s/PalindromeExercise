using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", "racecar")]
        [InlineData("civic", "civic")]
        [InlineData("radar", "radar")]
        [InlineData("level", "level")]
        [InlineData("rotor", "rotor")]
        [InlineData("kayak", "kayak")]
        [InlineData("madam", "madam")]
        [InlineData("refer", "refer")]
        public void PalindromeTest(string str, string expected)
        {
            //Arrange
            WordSmith wordSmith = new WordSmith();

            //Act
            string actual = wordSmith.Palindrome(str);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
