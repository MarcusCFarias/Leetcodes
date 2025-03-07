using System.Xml.Serialization;

namespace PartitionArrayAccordingToGivenPivot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 4, 0, 4, 5, -11 };
            int pivot = 5;

            int[] result = PivotArray(input, pivot);

            for (int i = 0; i < result.Length; i++)
                Console.Write($"{result[i]},");
        }
        public static int[] PivotArray_FirstAttemp(int[] nums, int pivot)
        {
            int[] output = new int[nums.Length];
            int indexLess = 0;
            int indexGreater = nums.Length - 1;

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNumber = nums[i];

                if (currentNumber < pivot)
                {
                    output[indexLess] = currentNumber;
                    indexLess++;
                }
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                int currentNumber = nums[i];

                if (currentNumber > pivot)
                {
                    output[indexGreater] = currentNumber;
                    indexGreater--;
                }
                else if (currentNumber == pivot)
                {
                    output[indexLess] = currentNumber;
                    indexLess++;
                }
            }

            return output;
        }

        public static int[] PivotArray(int[] nums, int pivot)
        {
            int[] output = new int[nums.Length];
            int right = nums.Length - 1;
            int left = 0;
            int currentNumber = 0;

            for (int i = 0, j = nums.Length - 1; i <= nums.Length - 1; i++, j--)
            {
                currentNumber = nums[i];
                if (currentNumber < pivot)
                {
                    output[left++] = currentNumber;
                }

                currentNumber = nums[j];
                if (currentNumber > pivot)
                {
                    output[right--] = currentNumber;
                }
            }

            while (left <= right)
            {
                output[left] = pivot;
                left++;
            }

            return output;
        }

        public static void Swap(int[] a, int indexA, int indexB)
        {
            int temp = a[indexA];
            a[indexA] = a[indexB];
            a[indexB] = temp;
        }
    }
}
