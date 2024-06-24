using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise;

public class WordSmith
{
    public bool Palindrome(string str)
    {
        var newS = new string(str.Where(x => char.IsLetter(x)).ToArray()).ToLower();

        return newS == new string(newS.Reverse().ToArray());
    }
}
