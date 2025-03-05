namespace ConcatenationOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 1 };

            int[] result = GetConcatenation_FirstAttempt(array);

            Console.Write("Answear: [");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{result[i]},");
            }

            Console.WriteLine("]");
        }
        public static int[] GetConcatenation_FirstAttempt(int[] nums)
        {
            int[] output = new int[nums.Length * 2];

            for (int i = 0; i < nums.Length; i++)
            {
                output[i] = nums[i];
                output[i + nums.Length] = nums[i];
            }

            return output;
        }
    }
}
