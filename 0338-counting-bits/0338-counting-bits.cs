public class Solution {
    public int[] CountBits(int n)
    {
        int[] result = new int[n + 1];
        for (int i = 0 ; i <= n ; i++)
        {
            result[i] = BinarySum(i);
        }
        return result;
    }


    public int BinarySum(int a)
    {
        int sum = 0;
        while (a > 0)
        {
            sum += a & 1;
            a = a >> 1;
        }
        return sum;
    }
}