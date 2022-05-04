
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionTwo
    {        
        public static int GetPitDepth(int[] points)
        {
            int arraySize = points.Length - 1;

            if (arraySize < 1 || arraySize >= 100000)
                throw new ArgumentOutOfRangeException(nameof(points), $"The length of points array must be within the range 1 to 1000,000");

            int depthOfdeepestPit = -1;            

            // Check if the array is long enough to store a pit
            if (arraySize < 2)
                return depthOfdeepestPit;

            for (int P = 0; P < arraySize - 2; P++)
            {
                //P_Point is the starting point
                int P_Point = points[P];
                int Q = P + 1;

                //Strictly decreasing sequence
                while (points[Q] < points[Q - 1] && Q < arraySize - 1)
                    Q++;

                //Check for flat line from decreasing sequence (No flat line)
                if (Q == P + 1)
                    continue;

                Q = Q - 1;

                //Q_Point is the lowest point
                int Q_Point = points[Q];
                int R = Q + 1;

                //Strictly increasing sequence
                while (points[R] > points[R - 1] && R < arraySize)
                    R++;

                //Check for flat line from increasing sequence (No flat line)
                if (R == Q + 1)
                    continue;

                R = R - 1;

                //R_Point is the last point
                int R_Point = points[R];

                //Only count the pit if the decline started above ground i.e.,0
                if (R_Point >= 0 && P_Point >= 0)
                    depthOfdeepestPit = Math.Max(depthOfdeepestPit, Math.Min(P_Point - Q_Point, R_Point - Q_Point));

            }

            return depthOfdeepestPit;
        }
    }
}
