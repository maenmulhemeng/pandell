using System;
using ConsoleApp2.Models;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp2
{
    
    class Program
    {

        static void Main(string[] args)
        {
            // Let's generate the numbers
            Dictionary<int, int> uniquechosenNumbers = UniqueRandomchosenNumbers(10000, 10000);
            
            // Then let's print them
            foreach (int no in uniquechosenNumbers.Keys)
            {
                Console.WriteLine(no);
            }
            Console.ReadLine();
        }
        public static Dictionary<int, int> UniqueRandomchosenNumbers(int maxRange, int totalRandomnoCount)
        {
            // List holds the previous chosen numbers in a dictionary so we can retrieve the calues in O(1)
            Dictionary<int, int> chosenNumbers = new Dictionary<int, int>();
            
            // Random numbers generator
            Random r = new Random();

            // Range of numbers 
            List<int> listRange = new List<int>();
            for (int i = 1; i <= totalRandomnoCount; i++)
            {
                listRange.Add(i);
            }
            while (listRange.Count > 0)
            {
                int item = r.Next(1,maxRange+1);// a random number in range [1,10000] 
                // if the random number has not been chosen yet O(1) and the we still can chose 
                if (!chosenNumbers.ContainsKey(item) && listRange.Count > 0)
                {
                    // let's add the random number to the list of the previous chosen numbers 
                    chosenNumbers.Add(item,item);
                    // and remove it from
                    listRange.Remove(item);
                }
            }
            return chosenNumbers;
        }
    }
}
