
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionTwo
    {
        public static int GetPitDepth(int[] points)
        {
            //o 0 ≤ P > Q < R;
            //o sequence[A[P], A[P + 1], ..., A[Q]] is strictly decreasing,
            //i.e.A[P] > A[P + 1] = A[Q];
            //o sequence A[Q], A[Q + 1], ..., A[R] is strictly increasing,
            //i.e.A[Q] < A[Q + 1] = A[R].
            //o The depth of a pit(P, Q, R) is the number min{ A[P] − A[Q], A[R] − A[Q]}.
           
            int depthOfdeepestPit = -1;
            int arraySize = points.Length - 1;

            if (arraySize < 2)
                return depthOfdeepestPit;


            for (int P = 0; P < arraySize - 2; P++)
            {                
                int P_Point = points[P];
                int Q = P + 1;

                while (points[Q] < points[Q - 1] && Q < arraySize - 1)
                    Q++;

                if (Q == P + 1)
                    continue;

                Q = Q - 1;
                
                int Q_Point = points[Q];
                int R = Q + 1;

                while (points[R] > points[R - 1] && R < arraySize)
                    R++;

                if (R == Q + 1)
                    continue;

                R = R - 1;
                
                int R_Point = points[R];
                                
                if (R_Point >= 0 && P_Point >= 0)
                    depthOfdeepestPit =Math.Max(depthOfdeepestPit, Math.Min(P_Point - Q_Point, R_Point - Q_Point));

            }

            return depthOfdeepestPit;
        }
    }
}
