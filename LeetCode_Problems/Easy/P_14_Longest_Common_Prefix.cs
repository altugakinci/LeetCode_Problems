namespace LeetCode_Problems.Easy;

public class P_14_Longest_Common_Prefix
{
    public string LongestCommonPrefix(string[] strs)
    {
        int minIndex = strs[0].Length;
        string prefix = "";

        foreach (string str in strs)
        {
            if (str.Length < minIndex)
            {
                minIndex = str.Length;
            }
        }

        for (int currentIndex = 0; currentIndex < minIndex; currentIndex++)
        {
            for (int currentStr = 0; currentStr < strs.Length - 1; currentStr++)
            {
                if (!strs[currentStr][currentIndex].Equals(strs[currentStr + 1][currentIndex]))
                {
                    return prefix;
                };
            }

            prefix += strs[0][currentIndex];
        }

        return prefix;
    }
}
