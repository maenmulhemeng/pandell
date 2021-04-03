# Pandell  
Please write a program that generates a list of 10,000 numbers in random order each time it is run. Each number in the list must be unique and be between 1 and 10,000 (inclusive).  

Job interview (Random numbers)  
# The algorithm 

let's iterate until we generate 10000 nnumbers  O(n). In each iteration let's first generate a random number and then check wheather this number has been already chosen during previous steps or not by O(1) using a dictionary. If the number is a new number so we add it to the chosenNumber dictionary and then we increase the counter by 1 and The core piece of code is.  
```
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
```
