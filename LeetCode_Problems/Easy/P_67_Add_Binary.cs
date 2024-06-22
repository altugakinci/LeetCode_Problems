namespace LeetCode_Problems.Easy;

public class P_67_Add_Binary
{
    public string AddBinary(string a, string b)
    {
        int[] aBits = new int[a.Length];
        int[] bBits = new int[b.Length];

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i].Equals('0'))
                aBits[i] = 0;
            else
                aBits[i] = 1;
        }
        for (int i = 0; i < b.Length; i++)
        {
            if (b[i].Equals('0'))
                bBits[i] = 0;
            else
                bBits[i] = 1;
        }

        aBits = aBits.Reverse().ToArray();
        bBits = bBits.Reverse().ToArray();
        int carry = 0;
        int maxSize = aBits.Length > bBits.Length ? aBits.Length : bBits.Length;
        int[] result = new int[maxSize + 1];
        int index = 0;
        int buffer;
        int aVal, bVal;

        while (index < maxSize)
        {
            if (index < aBits.Length)
                aVal = aBits[index];
            else
                aVal = 0;

            if (index < bBits.Length)
                bVal = bBits[index];
            else
                bVal = 0;

            buffer = aVal + bVal + carry;

            switch (buffer)
            {
                case 0:
                    carry = 0; break;
                case 1:
                    carry = 0; break;
                case 2:
                    carry = 1; break;
                case 3:
                    carry = 1; break;
            }

            buffer = buffer % 2;
            result[index] = buffer;
            index++;
        }

        if (carry == 1)
        {
            result[result.Length - 1] = 1;
            return String.Concat(result.Reverse());
        }
        else
        {
            int[] newResult = new int[result.Length - 1];
            Array.Copy(result, newResult, result.Length - 1);
            return String.Concat(newResult.Reverse());
        }
    }
}
