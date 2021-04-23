using System;
using  System.Collections.Generic;

namespace Lists2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> num = new List<string>();
         Console.WriteLine("please enter 5 numbers");
         num.Add(Console.ReadLine());
         num.Add(Console.ReadLine());
         num.Add(Console.ReadLine());
         num.Add(Console.ReadLine());
         num.Add(Console.ReadLine());

         int nums = int.Parse(num [0]);
         int nums1 = int.Parse(num [1]);
         int nums2 = int.Parse(num [2]);
         int nums3 = int.Parse(num [3]);
         int nums4 = int.Parse(num [4]);
        Console.WriteLine("enter last number");
        string input = Console.ReadLine();
        int inputnum = int.Parse(input);

         if (inputnum == nums) 
         {
            Console.WriteLine("number has already been added");
         }
         if (inputnum == nums1) 
         {
             Console.WriteLine("number has already been added");
         }
         if (inputnum == nums2)
         {
             Console.WriteLine("number has already been added");
         }
         if (inputnum == nums3) 
         {
             Console.WriteLine("number has already been added");
         }
         if (inputnum == nums4)
         {
             Console.WriteLine("number has already been added");
         }
        }
    }
}
