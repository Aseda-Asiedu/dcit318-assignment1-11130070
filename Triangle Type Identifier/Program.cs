using System;

namespace TriangleTypeIdentifierApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side 1: ");
            bool valid1 = int.TryParse(Console.ReadLine(), out int side1);

            Console.Write("Enter side 2: ");
            bool valid2 = int.TryParse(Console.ReadLine(), out int side2);

            Console.Write("Enter side 3: ");
            bool valid3 = int.TryParse(Console.ReadLine(), out int side3);

            if (valid1 && valid2 && valid3)
            {
                if (side1 == side2 && side2 == side3)
                    Console.WriteLine("This is an Equilateral triangle.");
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                    Console.WriteLine("This is an Isosceles triangle.");
                else
                    Console.WriteLine("This is a Scalene triangle.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter numbers for all sides.");
            }
        }
    }
}
