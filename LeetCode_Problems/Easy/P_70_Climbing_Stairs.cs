namespace LeetCode_Problems.Easy;

public class P_70_Climbing_Stairs
{
    public int ClimbStairs(int n)
    {
        if (n == 1)
            return 1;

        int a = 1, b = 1;
        int c = 0;

        for (int i = 2; i < n + 1; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c;
    }
}
