using System;
using  System.Collections.Generic;

namespace Lists2._2
{
    class Program
    {
        static void Main(string[] args)
        {
        List<string> list = new List<string>();
         Console.WriteLine("please enter 5 numbers");
         list.Add(Console.ReadLine());
         list.Add(Console.ReadLine());
         list.Add(Console.ReadLine());
         list.Add(Console.ReadLine());
         list.Add(Console.ReadLine());

         int nums = int.Parse(list [0]);
         int nums1 = int.Parse(list [1]);
         int nums2 = int.Parse(list [2]);
         int nums3 = int.Parse(list [3]);
         int nums4 = int.Parse(list [4]);
        Console.WriteLine("enter last number");
        string input = Console.ReadLine();
        int inputnum = int.Parse(input);
        int counter = 0;

        for (int index = 0; index < 5; index++)
        {
            if (input == list[index]) {
                counter ++;
            } 
        }

        Console.WriteLine("this number has been repeated " + counter + " times");
        }
    }
}
