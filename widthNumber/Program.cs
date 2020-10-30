using System;

namespace widthNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter one digit to width it: ");
            char charToWigth;
            bool isChar = char.TryParse(Console.ReadLine(), out charToWigth);
            while (!isChar)
            {
                Console.Write("Enter one digit to width it: ");
                isChar = char.TryParse(Console.ReadLine(), out charToWigth);
            }

            Console.Write("Enter the number (1-99) of desired width: ");
            
            int desiredWidth=0;
            bool isNumber = int.TryParse(Console.ReadLine(), out desiredWidth);

            while (!isNumber || desiredWidth>99)
            {
                Console.WriteLine("Enter the number from 1 to 99");
                isNumber = int.TryParse(Console.ReadLine(), out desiredWidth);
            }

            desiredWidth = Math.Abs(desiredWidth);
            int Width = desiredWidth; // if not that new int, loop will be shorter


            for (int i = 0; i < desiredWidth; i++)
            {
                for (int j = Width--; j > 0; j--)
                {
                    Console.Write(charToWigth);
                }
                Console.WriteLine();
            }
        }
    }
}
