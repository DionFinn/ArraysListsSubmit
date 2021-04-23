using System;
using  System.Collections.Generic;
namespace Lists2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
         Console.WriteLine("please enter words");
         string input = Console.ReadLine();
         
         while (input != "stop") {
             list.Add(input);
             input = Console.ReadLine();
         }

         list.Reverse();
         foreach(string anything in list) {
             Console.WriteLine(anything);
         }
        
        }   
    }
}
