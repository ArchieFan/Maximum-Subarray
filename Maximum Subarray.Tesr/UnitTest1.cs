namespace Maximum_Subarray.Tesr
{
    public class UnitTest1
    {
        [Theory]
        [InlineData( new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4  } , 6)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { -1 }, -1)]
        [InlineData(new int[] { 5, 4, -1, 7, 8 }, 23)]
        [InlineData(new int[] { -2, -1 }, -1)]
        public void Test1(int[] nums, int expected)
        {
            Solution s = new Solution();
            int res = s.MaxSubArray(nums);
            Assert.Equal(expected, res);
        }
    }
}