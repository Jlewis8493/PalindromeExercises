using System;
using System.Linq;


namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var reversed = word.Reverse().ToString();

            if(reversed.ToString() == word)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
