namespace LeetCode_Problems.Easy;

public class P_26_Remove_Duplicates_from_Sorted_Array
{
    public int RemoveDuplicates(int[] nums)
    {
        List<int> uniques = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int curr = nums[i];
            if (!uniques.Contains(curr))
                uniques.Add(curr);
        }
        for (int i = 0; i < uniques.Count; i++)
        {
            nums[i] = uniques[i];
        }

        return uniques.Count;
    }
}
