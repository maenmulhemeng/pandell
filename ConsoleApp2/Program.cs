using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    
    class Program
    {

        static void Main(string[] args)
        {
            // Let's generate the numbers
            List<int> uniquechosenNumbers = UniqueRandomchosenNumbers(10000, 10000);
            
            // Then let's print them
            foreach (int no in uniquechosenNumbers)
            {
                Console.WriteLine(no);
            }
            Console.ReadLine();
        }
        public static List<int> UniqueRandomchosenNumbers(int maxRange, int totalRandomnoCount)
        {
            // List holds the previous chosen numbers in a dictionary so we can retrieve the calues in O(1)
            Dictionary<int, int> chosenNumbers = new Dictionary<int, int>();
            
            // Random numbers generator
            Random r = new Random();

            int counter = 0;
          
            while (counter < totalRandomnoCount)
            {
                int item = r.Next(1,maxRange+1);// a random number in range [1,10000] 
                // if the random number has not been chosen yet O(1) and if we still can chose 
                if (!chosenNumbers.ContainsKey(item))
                {
                    // let's add the random number to the list of the previous chosen numbers 
                    chosenNumbers.Add(item,item);
                    counter++;
                }
            }
            return chosenNumbers.Keys.ToList();
        }
    }
}
