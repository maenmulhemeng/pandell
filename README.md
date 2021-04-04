# Pandell  
Please write a program that generates a list of 10,000 numbers in random order each time it is run. Each number in the list must be unique and be between 1 and 10,000 (inclusive).  

Job interview (Random numbers)  
# Solution 1

let's iterate until we generate 10000 nnumbers  O(n). In each iteration let's first generate a random number and then check wheather this number has been already chosen during previous steps or not by O(1) using a dictionary. If the number is a new number so we add it to the chosenNumber dictionary and then we increase the counter by 1 and The core piece of code is.  
```
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
```
I would say the worst cast of the complexity is O(n) but it this n holds in itself the abiility of the randoms generator to generate highly distributed numbers so it is in our case n = 10000 + number of duplicated numbers   
# Solution 2  
We can generate the required numbers range=[1,10000] and then pick up them randomly one by one by generating a random index. And then remove the chosen element from range. It worths to note that we don't check IF statment in the loop here which makes the complexity even better in the real time O(n) = o(n) and in our case is n = 10000.   
```
  // Lets create a list of the required numbers [1,2,3,4 ...etc]
  for (int i = 1; i <= maxRange; i++)
  {
      range.Add(i);
  }
  // While the numbmer of elements of the result list is less than the range    
  // Note that here we don't have IF statment in the O(n) loop 
  while (result.Count < maxRange)
  {
      // Chose random index
      int index = r.Next(0, range.Count);
      // Add the range[index] into the result
      result.Add(range[index]);
      // Remove range[index]
      range.RemoveAt(index);
  }
```

