public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int Msum = nums[0];
        int left = 0;
        int right = 0;
        int temp = 0;
        while (left < nums.Length)
        {
            if (right < nums.Length)
            {
                temp += nums[right];
                Msum = Math.Max(Msum, temp);
                if (temp > 0)
                {
                    right += 1;
                } else
                {
                    left += 1;
                    right = left;
                    temp = 0;
                }
            }
            else
            {
                left = right;
            } 
        }
        return Msum;
    }

    public int MaxSubArray2(int[] nums)
    {
        int Msum = nums[0];
        int temp = 0;

        foreach (var n in nums)
        {
            if (temp < 0) temp = 0;
            temp += n;
            Msum = Math.Max(Msum, temp);
        }
        return Msum;
    }

        static void Main()
    {
        int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        //int[] nums = { 1 };
        //int[] nums = { 5, 4, -1, 7, 8 };
        //int[] nums = { -1 };
        Solution s = new Solution();
        int res = s.MaxSubArray(nums);
        Console.WriteLine(res);
    }

}