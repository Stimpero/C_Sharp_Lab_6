﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Addition(params int[] integers)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine(result);
        }
        static void AdditionMas(int[] integers, int k)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += (integers[i] / k);
            }
            Console.WriteLine(result);
        }
        public static string StringExist(string s1, string s2)
        {
            string s3 = s1 + s2;
            return s3;
        }
        public static void ObType(object a)
        {

            Console.WriteLine(a.GetType());
        }
        static void Main(string[] args)
        {
            string str1 = "qwerty";
            string str2 = "123456";
            string str3 = "";
            Addition(1, 2, 3, 4, 5);

            int[] array = new int[] { 1, 2, 3, 4 };
            AdditionMas(array, 2);

            Console.WriteLine("{0}", str3 = StringExist(str1, str2));
            ObType(array);

            Console.ReadLine();
        }
    }
}
