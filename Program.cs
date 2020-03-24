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

            endUserSelection();
        }
        
        //Step 2
        //Defining a method that outputs each of the items.
        private static void outputGroceryList(string [] groceryList){ //This string [] statement within the method is stating that the argument that we are passing into it has to be an array and that it will be referred to as groceryList.
            //We use groceryList here because it helps us see that we are talking about the array as an argument and not as the variable defined above.

            //Output the groceryList
            for(int x = 0; x < groceryList.Length; x++){
                //Easy for loop. The x++ is the iteration. The x < groceryListItems is for determing the max number of cycles by the loop.
            
                Console.WriteLine($"Enter {x} for {groceryList[x]}");
                        //The $"Enter {x} for part is string concatentation. What that is doing is modifying the output by adding in those statements.
                        //The {x} becomes the number corresponding to the position of the item in the array. For example, "Nuts" are in position 0.
            }  
        }

        //Step 3
        //Defining a method that asks the user to input their item.
        public static void endUserSelection(){

            int userInput;

            Console.WriteLine("Please input a grocery list item");

            userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"You entered item number {userInput}");
        }
    }
}
