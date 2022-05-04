
using System.Text.RegularExpressions;

namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionOne
    {
        public static int GetLongestSentance(string s)
        {
            if (s.Length < 1 || s.Length > 100)
                throw new ArgumentOutOfRangeException(nameof(s), $"The length of String must be within the range 1 to 100");

            string[] sentences = s.Split('.', '!', '?');
            int mostSentenceWords = 0;

            foreach (string sentence in sentences)
            {
                string[] words = sentence.Trim().Split(' ');

                //A sentence can be divided into words by splitting it at spaces. A sentence without words
                //is valid, but a valid word must contain at least one letter.
                //words = words.Where(word => !Regex.IsMatch(word, @"/[a-zA-Z]/")).ToArray();
                if (words.Length > mostSentenceWords)
                    mostSentenceWords = words.Length;
            }

            return mostSentenceWords;
        }
    }
}




