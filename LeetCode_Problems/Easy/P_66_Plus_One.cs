namespace LeetCode_Problems.Easy;

public class P_66_Plus_One
{
    public int[] PlusOne(int[] digits)
    {
        int index = digits.Length - 1;

        int curr = digits[index];

        if (curr != 9)
        {
            digits[index] = curr + 1;
            return digits;
        }
        else
        {
            int carry = 1;
            do
            {
                curr = digits[index];

                if (curr + carry == 10)
                {
                    carry = 1;
                    digits[index] = 0;
                }
                else
                {
                    digits[index] = curr + carry;
                    carry = 0;
                }

                index--;
            } while (carry != 0 && index != -1);

            // If there is still a carry, then create a n+1 array.
            if (carry != 0)
            {
                int[] temp = new int[digits.Length + 1];
                temp[0] = 1;
                for (int i = 1; i < temp.Length; i++)
                {
                    temp[i] = digits[i - 1];
                }
                return temp;
            }
        }

        return digits;
    }
}
