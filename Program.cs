using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string userLength;
            string userWidth;
            string userHeight;
            
            Console.WriteLine("Welcome to the rectangle room space finder-er!");
            Console.WriteLine("Our terms and conditions mandate the sacrifice of all property, personal and intellectual, for the glory of Rome. Do you consent to these terms (y/n)?");
            string SPQR = Console.ReadLine();

            if ((SPQR == "y") || (SPQR == "Y") || (SPQR == "yes") || (SPQR == "Yes") || (SPQR == "YES"))
            {
                Console.WriteLine("Do you want to calculate the area of a room, or the volume of a room? Type 'area' or 'volume'.");

                string userChoice = Console.ReadLine();

                if ((userChoice == "volume") || (userChoice == "Volume"))
                {

                    Console.WriteLine("Please enter the metric length of the room in meters numerically.");
                    userLength = Console.ReadLine();
                    Console.WriteLine("Please enter the metric width of the room in meters numerically.");
                    userWidth = Console.ReadLine();
                    Console.WriteLine("Please enter the metric height of the room in meters numerically.");
                    userHeight = Console.ReadLine();

                    decimal userVolume = ((decimal.Parse(userLength)) * (decimal.Parse(userWidth)) * (decimal.Parse(userHeight)));

                    Console.WriteLine($"The volume of the room is {userVolume} meters cubed. The volume of Rome's ambition is infinite.");

                }
                else if ((userChoice == "area") || (userChoice == "Area"))
                {
                    Console.WriteLine("Please enter the metric length of the room in meters numerically.");
                    userLength = Console.ReadLine();
                    Console.WriteLine("Please enter the metric width of the room in meters numerically.");
                    userWidth = Console.ReadLine();

                    decimal userArea = ((decimal.Parse(userLength)) * (decimal.Parse(userWidth)));
                    decimal userPerimeter = ((decimal.Parse(userLength)) + (decimal.Parse(userWidth)) + (decimal.Parse(userLength)) + (decimal.Parse(userWidth)));

                    Console.WriteLine($"The area of the room is {userArea} meters squared. The border of the room is {userPerimeter} meters long. The area of Rome is too small. The borders of Rome must be expanded.");

                }
                else
                {
                    Console.WriteLine("You are an illiterate barbarian. Begone from my sight.");

                }
            }
            else
            {
                Console.WriteLine("Then Rome shall create a wasteland and call it peace.");
            }

            
        }
    }
}
