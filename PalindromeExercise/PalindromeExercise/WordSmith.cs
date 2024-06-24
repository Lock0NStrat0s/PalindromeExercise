using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise;

public class WordSmith
{
    public string Palindrome(string str)
    {
        return new string(str.Reverse().ToArray());
    }
}
