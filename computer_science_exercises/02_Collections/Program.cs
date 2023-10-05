//02_Collections, Albert Laguerre, v0.2b
using System;

namespace _02_Collections
{
    class Program
    {
        static Void Main(string[] urgs)
        {
           // Collections are variables that can store multiple values in one variable

           /* Arrays
           -- Number of elements in an array CANNOT change
           -- Contents of elements in an aaray CAN change
           -- Items in the array are called ELEMENTS
           -- Arrays are ordered, meaning each item has a fixed position 
           -- The position is known as the INDEX
           -- First element in an array is index 0.
           */

           // Delcaring and Defining an Array
           string[] breakfastFoods = {"Bacnon", "Waffles", "Pancakes", "Cereal", "Parfait"};
           int[] testScores = {95, 100, 25, 15, 27, 35};
           float[] GPA = {3.15f, 2.25f, 1.74f, 1.99f, 0.99f, 4.25f};

           // Print Array Contents -- ALL elements on Single Line
           Console.WriteLine("The element for each array are:\n");
           Console.WriteLine("breakfastFoods: \n" + String.Join(",", breakfastFoods));
           Console.WriteLine();
           Console.WriteLine("testSCores: \n" + String.Join(",", testScores));
           Console.WriteLine();
           Console.WriteLine("Gpa: \n" + String.Join(",", GPA));
           Console.WriteLine();

           /* Print array contents -- each element on separate line
           Console.WriteLine("The elements for each array are:\n");
           Console.WriteLine("breakfastFoods: \n" + String.Join("\n", breakfastFoods));
           Console.WriteLine();
           Console.WriteLine("testSCores: \n" + String.Join("\n", testScores));
           Console.WriteLine();
           Console.WriteLine("Gpa: \n" + String.Join("\n", GPA));
           Console.WriteLine();
           */

           // Determining Array length
           Console.WriteLine("The length of each array is:\n");
           Console.WriteLine("breakfastFoods: " + breakfastFoods.Length);
           Console.WriteLine("testScores: " + testScores.Length);
           Console.WriteLine("GPA: " + GPA.Length);

           // Accessing Array Elements -- use the index
           Console.WriteLine("The first element in each array is:\n");
           Console.WriteLine("breakfastFoods: " + breakfastFoods[0]);
           Console.WriteLine("testScores: " + testScores[0]);
           Console.WriteLine("GPA: " + GPA[0]);

           // Access Last Element
           Console.WriteLine("The last element in each array is:\n");
           Console.WriteLine("breakfastFoods: " + breakfastFoods[breakfastFoods.Length - 1]);
           Console.WriteLine("testScores: " + testScores[testScores.Length - 1]);
           Console.WriteLine("GPA: " + GPA[GPA.Length - 1]);

           // PWYOC -- Please Write your own code
           // v0.2b -- Access the third element in each arrau and print to the screen
           Console.WriteLine("The first element in each array is:\n");
           Console.WriteLine("breakfastFoods: " + breakfastFoods[2]);
           Console.WriteLine("testScores: " + testScores[2]);
           Console.WriteLine("GPA: " + GPA[2]);









        }
    }
}