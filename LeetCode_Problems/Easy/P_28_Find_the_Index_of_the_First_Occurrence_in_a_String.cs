namespace LeetCode_Problems.Easy;

public class P_28_Find_the_Index_of_the_First_Occurrence_in_a_String
{
    public int StrStr_1(string haystack, string needle)
    {
        if (haystack.Length < needle.Length)
            return -1;

        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            if (haystack.Substring(i, needle.Length) == needle)
                return i;
        }

        return -1;
    }

    public int StrStr_2(string haystack, string needle)
    {
        return haystack.IndexOf(needle);
    }
}
