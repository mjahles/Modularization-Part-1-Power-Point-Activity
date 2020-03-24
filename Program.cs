using System;

namespace modularization_pp_activity1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1
            //Declaring Global Variables
            string[] groceryListItems = {"Nuts", "Fish", "Lentils", "Whole Grains", "Beans", "Olive Oil", "Eggs", "Yogurt"};
            
            int userInput;
            outputGroceryList(groceryListItems);
        }
        
        //Step 2
        //Defining a method that outputs each of the items.
        private static void outputGroceryList(string [] groceryList){
            //We use groceryList here because it helps us see that we are talking about the array as an argument and not as the variable defined above.

            //Output the groceryList
            for(int x = 0; x < groceryList.Length; x++){
                //Easy for loop. The x++ is the iteration. The x < groceryListItems is for determing the max number of cycles by the loop.
            
                Console.WriteLine(groceryList[x]);
            }  
        }
    }
}
