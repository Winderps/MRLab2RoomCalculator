using System;

namespace Lab2RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont)
            {
                Console.Write("Please enter the room's length: ");
                double roomLength = double.Parse(Console.ReadLine());
                Console.Write("Please enter the room's width: ");
                double roomWidth = double.Parse(Console.ReadLine());
                Console.Write("Please enter the room's height: ");
                double roomHeight = double.Parse(Console.ReadLine());

                Console.WriteLine(
                    $"Room perimiter: {(roomLength * 2) + (roomWidth * 2)}\n" +
                    $"Room area: {roomWidth * roomLength}\n" +
                    $"Room volume: {roomWidth * roomLength * roomHeight}"
                );

                Console.Write("Enter y(es) to measure another room or anything else to exit: ");

                cont = Console.ReadLine().ToLower().StartsWith("y");
            }
        }
    }
}
