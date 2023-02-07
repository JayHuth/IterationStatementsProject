using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();
                       
             var myNumber = 0;

            do
            {
                myNumber++;
                numbers.Add(myNumber);                           

            } while (myNumber < 100);

            // Create a while loop
            // <--- While num is less than 200
            while (myNumber < 200) 
            {
                myNumber++;
                numbers.Add(myNumber);

            }                                     

            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");

                foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }        
                         
            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine($"{numbers[i]}");
            }

            //------------End of exercise
        }
    }
}
