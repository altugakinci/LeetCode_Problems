namespace LeetCode_Problems.Easy;

public class P_27_Remove_Element
{
    public int RemoveElement(int[] nums, int val)
    {
        int index = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int curr = nums[i];
            if (curr != val)
            {
                nums[index] = curr;
                index++;
            }
        }
        return index;
    }
}
