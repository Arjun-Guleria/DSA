namespace DSA.Arrays
{
    public class TwoSumSolution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                    return new int[] { map[complement], i };
                map[nums[i]] = i;
            }
            return Array.Empty<int>();
        }
    }
}