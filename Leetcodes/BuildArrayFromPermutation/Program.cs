namespace BuildArrayFromPermutation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 5, 0, 1, 2, 3, 4 };
            int[] result = BuildArray(input);

            for (int i = 0; i < result.Length; i++)
                Console.Write($"{result[i]},");

        }
        public static int[] BuildArray(int[] nums)
        {
            int[] output = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                output[i] = nums[nums[i]];

            }
            //GC.Collect();
            return output;
        }
    }
}
