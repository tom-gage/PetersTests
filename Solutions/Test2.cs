using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PetersTests.Solutions
{
    internal class Test2
    {
        public static int Solution(string S)
        {
            int highestWordCount = 0;
            string[] sentences = S.Split(new char[] {'.', '?', '!', '\n'});

            foreach(string sentence in sentences)
            {
                Regex word = new Regex(@"\w+");
                int wordCount = word.Matches(sentence).Count;

                if(wordCount > highestWordCount)
                {
                    highestWordCount = wordCount;
                }
            }

            return highestWordCount;
        }

    }
}
