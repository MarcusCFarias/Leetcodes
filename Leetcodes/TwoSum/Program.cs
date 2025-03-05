namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            int target = 11;

            int[] result = TwoSum(nums, target);

            Console.WriteLine($"The answear: [{result[0]}, {result[1]}]");
        }

        public static int[] TwoSum_FirstAttempt(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }

            return new int[] { };
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNumber = nums[i];
                int lookupNum = target - currentNumber;

                if (map.ContainsKey(lookupNum))
                    return new int[] { map[lookupNum], i };

                map[currentNumber] = i;
            }

            return new int[] { };
        }
    }
}
