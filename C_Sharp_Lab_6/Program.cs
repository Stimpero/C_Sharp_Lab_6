﻿using System;

namespace C_Sharp_Lab_6
{
    class Example
    {
        public int x, y;

        public Example()
        {

        }

        public Example(int x)
        {
            this.x = x;
        }
        public static void Sqr(double a, double b)
        {
            a = Math.Pow(a, 2);
            b = Math.Pow(b, 2);
            Console.WriteLine("В методе Sqr\ta^2 = {0}\tb^2 = {1}", a, b);

        }
        public static void Init(Example e)
        {

            Console.WriteLine("В методе Init:\nx={0}\ny={1}", e.x, e.y);
            e.x = 1;
            e.y = 1;
            Console.WriteLine("В методе Init:\nx={0}\ny={1}", e.x, e.y);
            Example ob2 = new Example(3);
            e.x = ob2.x;
            e.y = ob2.y;
            Console.WriteLine("В методе Init присвоение нового объекта:\nx={0}\ny={1}", e.x, e.y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double da = 1.23, db = 56.78;
            Console.WriteLine("a = {0}; b = {1}", da, db);
            Example.Sqr(da, db);
            Example.Sqr(da * 2, db * 2);
            Console.WriteLine("В функции main\ta = {0}\tb = {1}", da, db);

            Example ob1 = new Example(5);
            Console.WriteLine("В методе Main: Obj.x = {0}\tObj.y = {1}", ob1.x, ob1.y);
            Example.Init(ob1);
            Console.WriteLine("В методе Main: Obj.x = {0}\tObj.y = {1}", ob1.x, ob1.y);
        }
    }
}