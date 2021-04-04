using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    
    class Program
    {

        static void Main(string[] args)
        {
            const int n = 10000;
            // Let's generate the numbers
            // Solution 1 : consumes linear memory n = 10000 and check if condition more than solution 2    
            //List<int> uniquechosenNumbers = solution1(n);

            // Soltion 2 : consumes linear memory n = 10000 and less if condition checking operations
            List<int> uniquechosenNumbers = solution2(n);

            // Then let's print them
            foreach (int no in uniquechosenNumbers)
            {
                Console.WriteLine(no);
            }
            Console.ReadLine();
        }
        public static List<int> solution1(int maxRange)
        {
            // List holds the previous chosen numbers in a dictionary so we can retrieve the calues in O(1)
            Dictionary<int, int> result = new Dictionary<int, int>();
            
            // Random numbers generator
            Random r = new Random();

            int counter = 0;
          
            while (counter < maxRange)
            {
                int item = r.Next(1,maxRange+1);// a random number in range [1,10000] 
                // if the random number has not been chosen yet O(1) and if we still can chose 
                if (!result.ContainsKey(item))
                {
                    // let's add the random number to the list of the previous chosen numbers 
                    result.Add(item,item);
                    counter++;
                }
            }
            return result.Keys.ToList();
        }
        public static List<int> solution2(int maxRange)
        {
            // List holds the previous chosen numbers in a dictionary so we can retrieve the calues in O(1)
            List<int> result = new List<int>();

            // Random numbers generator
            Random r = new Random();

            List<int> range = new List<int>();

            // Lets create a list of the required numbers [1,2,3,4 ...etc]
            for (int i = 1; i <= maxRange; i++)
            {
                range.Add(i);
            }
            // While the numbmer of elements of the result list is less than the range    
            while (result.Count < maxRange)
            {
                // Chose random index
                int index = r.Next(0, range.Count);
                // Add the range[index] into the result
                result.Add(range[index]);
                // Remove range[index]
                range.RemoveAt(index);
            }
            return result;
        }

    }
}
