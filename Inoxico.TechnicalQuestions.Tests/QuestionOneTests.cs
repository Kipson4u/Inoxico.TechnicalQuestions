using Inoxico.TechnicalQuestions.Answers;
using Xunit;

namespace Inoxico.TechnicalQuestions.Tests
{
    public class QuestionOneTests
    {
        [Fact]
        public void ExampleTest()
        {
            var input = $"We test coders. Give us a try?";
            var outcome = QuestionOne.GetLongestSentance(input);

            Assert.Equal(4, outcome);
        }

        [Fact]
        public void GetLongestSentance_Must_Be_2_Test()
        {
            var input = $"Forget CVs..Save time . x x";
            var outcome = QuestionOne.GetLongestSentance(input);

            Assert.Equal(2, outcome);
        }
    }
}