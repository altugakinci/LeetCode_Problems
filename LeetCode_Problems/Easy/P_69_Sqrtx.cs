namespace LeetCode_Problems.Easy;

public class P_69_Sqrtx
{
    public int MySqrt(int x)
    {
        if (x == 1)
            return 1;

        long l = 0, r = x, mean, buffer, prod;

        buffer = r;

        while (true)
        {
            mean = (l + r) / 2;

            if (mean == buffer)
                return (int)mean;

            buffer = mean;

            prod = mean * mean;

            if (prod < 0)
            {
                r = mean;
                continue;
            }

            if (prod == x)
                return (int)mean;

            if (prod > x)
                r = mean;
            else
                l = mean;
        }
    }
}
