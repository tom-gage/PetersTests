using PetersTests.Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PetersTests.Tests
{
    public class Test2Tests
    {
        [Fact]
        public void singleSentence()
        {
            string sentence = "Hello there.";
            int expected = 2;
            int actual = Test2.Solution(sentence);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void twoSentences()
        {
            string sentence = "Hello there. General Kenobi.";
            int expected = 2;
            int actual = Test2.Solution(sentence);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void threeSentencesPunctuation()
        {
            string sentence = "Hello there? General Kenobi! How nice to see you!";
            int expected = 5;
            int actual = Test2.Solution(sentence);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void threeSentencesEoL()
        {
            string sentence = "Hello there! General Kenobi. How nice to see you";
            int expected = 5;
            int actual = Test2.Solution(sentence);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void allPunctuation()
        {
            string sentence = "!?..?!!?..?!";
            int expected = 0;
            int actual = Test2.Solution(sentence);

            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void empty()
        {
            string sentence = "";
            int expected = 0;
            int actual = Test2.Solution(sentence);

            Assert.Equal(expected, actual);
        }
    }
}
