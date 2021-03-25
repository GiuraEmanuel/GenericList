using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            PracticeList<int> practiceList = new PracticeList<int>();
            practiceList.Add(2);
            practiceList.Add(3);
            practiceList.Add(4);
            practiceList.Add(5);
            practiceList.Add(1);
            practiceList.Add(6);
            practiceList.Add(7);
            practiceList.Add(8);
            practiceList.Add(12);
            practiceList.Add(33);

            Console.WriteLine();

            foreach (var item in practiceList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(practiceList.Contains(12));
        }
    }
}
