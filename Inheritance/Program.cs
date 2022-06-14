using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal DONE
            // give this class 4 members that all Animals have in common DONE


            // Create a class Bird DONE
            // give this class 4 members that are specific to Bird DONE
            // Set this class to inherit from your Animal Class DONE

            // Create a class Reptile DONE
            // give this class 4 members that are specific to Reptile DONE
            // Set this class to inherit from your Animal Class DONE




            /*Create an object of your Bird class DONE
             *  give values to your members using the object of your Bird class DONE
             *  
             * Creatively display the class member values  DONE
             */

            /*Create an object of your Reptile class DONE
             *  give values to your members using the object of your Reptile class DONE
             *  
             * Creatively display the class member values DONE
             */

            Bird cardinal = new Bird();

            cardinal.DoesItFly = true;
            cardinal.HasFeathers = true;
            cardinal.FeatherColor = "red";
            cardinal.MigratoryPattern = "doesn't migrate";
            cardinal.TalonOnFoot = 4;

            Reptile kamodoDragon = new Reptile();

            kamodoDragon.ReptileColor = "black";
            kamodoDragon.EggsPerYear = 38;
            kamodoDragon.IsCarnivore = true;
            kamodoDragon.IsOmnivore = false;

            Console.WriteLine($"The Cardinal is a majestic bird that has beautiful {cardinal.FeatherColor} feathers.");
            Console.WriteLine("");
            Console.WriteLine($"Although it is {cardinal.DoesItFly}, the cardinal does fly, it {cardinal.MigratoryPattern}.");
            Console.WriteLine("");
            Console.WriteLine($"The Kamodo Dragon is a large {kamodoDragon.ReptileColor} reptile \r\nthat lives on a select few Indonesian islands.");
            Console.WriteLine("");
            Console.WriteLine($"A common misconception is that a kamodo dragon is an omnivore. This is {kamodoDragon.IsOmnivore}.");
            Console.WriteLine("");
            Console.WriteLine($"Assuming a healthy breeding season, a kamodo dragon can lay \r\nup to {kamodoDragon.EggsPerYear} eggs per year.");
        }
    }
}
