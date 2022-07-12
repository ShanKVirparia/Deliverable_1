using System;

namespace Deliverable_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                // Determin how people want PB and J
                Console.WriteLine("How many people need a PB and J?");
                var people = Convert.ToInt32(Console.ReadLine());

                //Slice of Bread
                double totalSlicesOfBread = people * 2;
                Console.WriteLine("The total slices of beard are " + totalSlicesOfBread + " slices.");

                //Tablespoon of PB
                double totalTablespoonOfPB = people * 2;
                Console.WriteLine("The total tablespoons of peanut butter are " + totalTablespoonOfPB + " tbps.");

                //Tablespoon of Jelly
                double totalTablespoonOfJelly = people * 4;
                Console.WriteLine("The total number of tablespoons of jelly are " + totalTablespoonOfJelly + " tbps.");

                //Loaves needed
                double totalLoaves = Math.Round((totalSlicesOfBread / 28));
                Console.WriteLine("The total loaves of beard needed are " + totalLoaves + ".");

                //Jar of PB
                double totalJarsOfPeanutButter = Math.Round((totalTablespoonOfPB / 32));
                Console.WriteLine("The total jars of peanut bar needed are " + totalJarsOfPeanutButter + ".");

                //Jars of Jelly
                double totalJarsOfJelly = Math.Round((totalTablespoonOfJelly / 48));
                Console.WriteLine("The total jars of jelly needed are " + totalJarsOfJelly + ".");

                //Restart Program
                Console.WriteLine("Enter Yes or y to continue, or enter any other key to exit.");
                var restart = Convert.ToString(Console.ReadLine());
                
                if (restart == "Yes" || restart == "y")
                {
                    continue;
                }
                else if (restart != "Yes" || restart != "y")
                {
                    Console.WriteLine("Goodbye");
                    
                }

                break;
                
            }
            
        }
    }
}
