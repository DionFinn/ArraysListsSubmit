using System;

namespace Arrays1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert 5 names");
            string[] names = new string [5] {Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine()};
            
            
            Console.WriteLine("hello " + names [0]);
            Console.WriteLine("hello " + names [1]);
            Console.WriteLine("hello " + names [2]);
            Console.WriteLine("hello " + names [3]);
            Console.WriteLine("hello " + names [4]);
            
        }
    }
}
