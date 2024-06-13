namespace LeetCode_Problems.Easy;

public class P_20_Valid_Parentheses
{
    public bool IsValid(string s)
    {
        Dictionary<char, char> parentheses = new Dictionary<char, char>()
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        List<char> opens = new List<char>();

        foreach (var p in s)
        {
            if (parentheses.Values.Contains(p))
            {
                opens.Add(p);
                continue;
            }

            if (parentheses.Keys.Contains(p) && opens.Any() && opens.Last().Equals(parentheses[p]))
                opens.RemoveAt(opens.Count - 1);
            else
                return false;
        }

        if (opens.Any())
            return false;

        return true;
    }
}
