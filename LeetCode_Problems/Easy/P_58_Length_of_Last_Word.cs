namespace LeetCode_Problems.Easy;

public class P_58_Length_of_Last_Word
{
    public int LengthOfLastWord(string s)
    {
        int index = 0;
        int counter = 0;
        int lastWord = 0;

        while (index < s.Length)
        {
            if (s[index] == ' ')
            {
                if (counter != 0)
                    lastWord = counter;
                counter = 0;
            }
            else
                counter++;

            index++;
        }

        if (counter != 0)
            lastWord = counter;

        return lastWord;
    }
}
