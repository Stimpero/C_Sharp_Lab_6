using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace param_array
{
    class Program
    {
        public static double Average(params int[] arr)
        {
            double av = 0;
            foreach (int elem in arr)
                av += elem;
            return (av / arr.Length);

        }
        static void Main(string[] args)
        {
            var rand = new Random();
            int[] arr = new int[4];
            for (int i = 0; i < 4; i++)
            {
                arr[i] = rand.Next(10, 20);
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Cреднее значение массива: {0}", Average(arr));
            short z = 1, e = 12;
            byte v = 107;
            Console.WriteLine(Average(z, e, v));
            Console.WriteLine("Cреднее значение массива: {0}", Average());

        }
    }
}