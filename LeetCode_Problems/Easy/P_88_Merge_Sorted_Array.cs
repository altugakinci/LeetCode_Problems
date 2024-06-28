namespace LeetCode_Problems.Easy;

internal class P_88_Merge_Sorted_Array
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int nums1Index = m;
        bool inserted;

        for (int i = 0; i < n; i++)
        {
            inserted = false;

            for (int j = 0; j < nums1Index; j++)
            {
                if (nums1[j] > nums2[i])
                {
                    InsertToArray(nums1, j, nums2[i]);
                    nums1Index++;
                    inserted = true;
                    break;
                }
            }

            if (!inserted)
            {
                InsertToArray(nums1, nums1Index, nums2[i]);
                nums1Index++;
            }
        }
    }

    public void InsertToArray(int[] array, int index, int value)
    {
        for (int i = array.Length - 1; i > index; i--)
        {
            array[i] = array[i - 1];
        }
        array[index] = value;
    }
}
