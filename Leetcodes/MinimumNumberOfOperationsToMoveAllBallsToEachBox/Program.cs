using System.Runtime.InteropServices;

namespace MinimumNumberOfOperationsToMoveAllBallsToEachBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string boxes = "001011";

            int[] result = MinOperations(boxes);

            Console.Write("Answear: [");
            for (int i = 0; i < result.Length; i++)
                Console.Write($"{result[i]},");

            Console.WriteLine("]");
        }

        public static int[] MinOperations_FirstAttempt(string boxes)
        {
            int[] output = new int[boxes.Length];

            for (int i = 0; i < boxes.Length; i++)
            {
                for (int j = 0; j < boxes.Length; j++)
                {
                    char c = boxes[j];

                    if (i != j && c == '1')
                    {
                        output[i] = output[i] + Math.Abs(i - j);
                    }
                }
            }

            return output;
        }
        public static int[] MinOperations(string boxes)
        {
            int n = boxes.Length;
            int[] output = new int[n];

            int leftBalls = 0, leftToRightMoves = 0;
            int rightBalls = 0, rightToLeftMoves = 0;

            for (int i = 0; i < boxes.Length; i++)
            {
                Console.WriteLine($"i: {i}, has the '{boxes[i]}' value.");
                
                output[i] = output[i] + leftToRightMoves;

                Console.WriteLine($"How many leftBalls at {i}: {leftBalls}");
                Console.WriteLine($"How many moves from left to right to reach {i}: {leftToRightMoves}");

                leftBalls = leftBalls + (int)Char.GetNumericValue(boxes[i]);
                leftToRightMoves = leftToRightMoves + leftBalls;

                Console.WriteLine();

                int j = n - 1 - i;
                Console.WriteLine($"j: {j}, has the '{boxes[j]}' value.");

                output[j] = output[j] + rightToLeftMoves;

                Console.WriteLine($"How many rightBalls at {j}: {rightBalls}");
                Console.WriteLine($"How many moves from right to left to reach {j}: {rightToLeftMoves}");

                rightBalls = rightBalls + (int)Char.GetNumericValue(boxes[j]);
                rightToLeftMoves = rightToLeftMoves + rightBalls;

                Console.Write("Array output: ");
                PrintArray(output);

                Console.WriteLine("------------------------------");
            }

            return output;
        }

        public static void PrintArray(int[] a)
        {
            Console.Write("[");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]},");
            }
            Console.WriteLine("]");
        }
    }
}
