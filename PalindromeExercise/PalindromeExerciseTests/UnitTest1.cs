using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("civic", true)]
        [InlineData("radar", true)]
        [InlineData("level", true)]
        [InlineData("qwerty", false)]
        [InlineData("zxcv", false)]
        [InlineData("Dennis, Nell, Edna, Leon, Nedra, Anita, Rolf, Nora, Alice, Carol, Leo, Jane, Reed, Dena, Dale, Basil, Rae, Penny, Lana, Dave, Denny, Lena, Ida, Bernadette, Ben, Ray, Lila, Nina, Jo, Ira, Mara, Sara, Mario, Jan, Ina, Lily, Arne, Bette, Dan, Reba, Diane, Lynn, Ed, Eva, Dana, Lynne, Pearl, Isabel, Ada, Ned, Dee, Rena, Joel, Lora, Cecil, Aaron, Flora, Tina, Arden, Noel, and Ellen sinned.", true)]
        public void PalindromeTest(string str, bool expected)
        {
            //Arrange
            WordSmith wordSmith = new WordSmith();

            //Act
            bool actual = wordSmith.Palindrome(str);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
