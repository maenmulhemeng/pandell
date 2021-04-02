using System;
using ConsoleApp2.Models;
using System.Collections.Generic;
namespace ConsoleApp2
{
    
    class Program
    {

        static void Main(string[] args)
        {
            List<int> uniqueNoList = new List<int>();
            uniqueNoList = UniqueRandomNoList(10000, 10000);
            foreach (int no in uniqueNoList)
            {
                Console.WriteLine(no);
            }
            Console.ReadLine();
        }
        public static List<int> UniqueRandomNoList(int maxRange, int totalRandomnoCount)
        {

            List<int> noList = new List<int>();
            int count = 0;
            Random r = new Random();
            List<int> listRange = new List<int>();
            for (int i = 0; i < totalRandomnoCount; i++)
            {
                listRange.Add(i);
            }
            while (listRange.Count > 0)
            {
                int item = r.Next(maxRange);// listRange[];    
                if (!noList.Contains(item) && listRange.Count > 0)
                {
                    noList.Add(item);
                    listRange.Remove(count);
                    count++;
                }
            }
            return noList;
        }
    }
}
