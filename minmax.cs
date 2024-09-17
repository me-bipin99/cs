using System;


namespace fifthsemDotnet
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] num = {  2, 39, 14, 5, 6, 7, 3, 9, 20, 11, 10 };
            int min = num[0];
            int max = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                if (min > num[i])
                {
                    min = num[i];
                }
                if (max < num[i])
                {
                    max = num[i];
                }
            }
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximun: " + max);
            Console.ReadKey();
        }
    }
}
