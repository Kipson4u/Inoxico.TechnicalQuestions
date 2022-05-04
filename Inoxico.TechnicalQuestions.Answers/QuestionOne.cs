
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionOne
    {
        public static int GetLongestSentance(string s)
        {
            string[] sentences = s.Split('.', '!', '?');
            int mostSentenceWords = 0;

            foreach (string sentence in sentences)
            {
                string[] words = sentence.Trim().Split(' ');
                
                if (words.Length > mostSentenceWords)
                    mostSentenceWords = words.Length;
            }

            return mostSentenceWords;
        }
    }
}




