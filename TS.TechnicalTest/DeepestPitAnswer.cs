namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        // Initialize variables to track the deepest pit
        int deepestPit = -1;
        int n = points.Length;
        
        // Iterate through the array to find pits
        for (int i = 0; i <= n - 3; i++)
        {
            if (points[i] >= 0)
            {
                int p = points[i];
                int q = points[i + 1];
                int r = points[i + 2];
                
                if (p > q && r > q)
                {
                    int depth = Math.Min(p - q, r - q);
                    if (depth > deepestPit)
                    {
                        deepestPit = depth;
                    }
                }
            }
        }
        return deepestPit;
    }
}
