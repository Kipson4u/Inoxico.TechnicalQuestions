using Inoxico.TechnicalQuestions.Answers;
using Xunit;

namespace Inoxico.TechnicalQuestions.Tests
{
    public class QuestionTwoTests

    {
        [Fact]
        public void SampleTest()
        {
            var points = new[] { 0, 1, 3, -2, 0, 1, 0, -3, 2, 3 };

            var result = QuestionTwo.GetPitDepth(points);

            Assert.Equal(4, result);
        }

        [Fact]
        public void GetPitDepth_Must_Return_2_Test()
        {
            var points = new[] { 1, 2, 3, 1, 2, 3, 1, 2, 3 };

            var result = QuestionTwo.GetPitDepth(points);

            Assert.Equal(2, result);
        }
    }
}