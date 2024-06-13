namespace LeetCode_Problems.Easy;

public class P_13_Roman_To_Integer
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> values = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        int buffer = 0;
        int total = 0;

        buffer += values[s[0]];

        for (int i = 0; i < s.Length - 1; i++)
        {
            int curr = values[s[i]];
            int next = values[s[i + 1]];

            if (curr == next)
            {
                buffer += next;
            }
            else if (curr > next)
            {
                total += buffer;
                buffer = next;
            }
            else
            {
                total += next - buffer;
                buffer = 0;
            }
        }

        total += buffer;

        return total;
    }
}


