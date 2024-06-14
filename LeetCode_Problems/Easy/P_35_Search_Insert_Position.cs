namespace LeetCode_Problems.Easy;

public class P_35_Search_Insert_Position
{
    public int SearchInsert(int[] nums, int target)
    {
        if (nums[0] > target)
            return 0;
        if (nums[nums.Length - 1] < target)
            return nums.Length;

        int l = 0, r = nums.Length - 1;

        while (true)
        {
            if (nums[l] >= target)
                return l;
            if (nums[r] < target)
                return r + 1;
            l++; r--;
        }
    }
}
