using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            PracticeList<int> practiceList = new PracticeList<int>();
            practiceList.Add(3);
            practiceList.Add(6);
            practiceList.Add(7);
            practiceList.Add(9);
            practiceList.Add(1);

            practiceList.Remove(3);

            Console.WriteLine(practiceList.Count);
        }
    }
}
