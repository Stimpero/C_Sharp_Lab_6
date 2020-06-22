using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @out
{
    class Example
    {
        public int x, y;
        public static void _3(double value, out int sign, out bool isInt, out double abs, out double sqr)
        {
            sign = Math.Sign(value);
            isInt = (value % 1 == 0) ? true : false;
            abs = Math.Abs(value);
            sqr = value * value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double a = 42, b = -12.67;
            double c, d;
            int i;
            bool check;
            Example._3(a, out i, out check, out c, out d);
            Console.WriteLine("Число: {0}\tЗнак: {1}\tЦелое число: {2}\tМодуль: {3}\tКвадрат числа: {4}\t", a, i, check, c, d);
            Example._3(d, out i, out check, out c, out d);
            Console.WriteLine("Число: {0}\tЗнак: {1}\tЦелое число: {2}\tМодуль: {3}\tКвадрат числа: {4}\t", d, i, check, c, d);
            Example._3(b, out i, out check, out c, out d);
            Console.WriteLine("Число: {0}\tЗнак: {1}\tЦелое число: {2}\tМодуль: {3}\tКвадрат числа: {4}\t", a, i, check, c, d);
            Example._3(d, out i, out check, out c, out d);
            Console.WriteLine("Число: {0}\tЗнак: {1}\tЦелое число: {2}\tМодуль: {3}\tКвадрат числа: {4}\t", d, i, check, c, d);

        }
    }
}
