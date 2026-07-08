namespace Exercise1_EvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intArray = GetEvenNumbers(17, 4); //Result = [4, 8, 12, 16]
            //var intArray = GetEvenNumbers(21, 7); //Result = [14]
            //var intArray = GetEvenNumbers(5, 20); //Result = [10, 20]
            //var intArray = GetEvenNumbers(3, 10); //Result = [6]
            //var intArray = GetEvenNumbers(2, 2); //Result = [2]

            foreach (var i in intArray)
            {
                Console.Write($"{i}, ");
            }
        }

        private static int[] GetEvenNumbers(int num1, int num2)
        {
            var nums = new List<int>();
            int start, end;

            if (num1 < num2)
            {
                start = num2;
                end = num1;
            }
            else
            {
                start = num1;
                end = num2;
            }

            for (int i = 2; i <= start; i++)
            {
                if (i % end == 0 && i % 2 == 0)
                {
                    nums.Add(i);
                }
            }

            return nums.ToArray();

        }
    }
}
