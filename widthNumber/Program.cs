using System;

namespace widthNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter one digit to width it: ");
            var val = (Console.ReadLine());

            Console.Write("Enter the number of desired width: ");
            int desiredWidth = int.Parse(Console.ReadLine());

            int Width = desiredWidth; // if not that new int, loop will be shorter

            for (int i = 0; i < desiredWidth; i++)
            {
                for (int j = Width--; j > 0; j--)
                {
                    Console.Write(val + " ");
                }
                Console.WriteLine();
            }
            //  Przetestuj skrajne przypadki, co jeśli wpiszemy:

            //   - liczbę ujemną (dziala)

            //   - coś co nie jest liczbą
            //  System.FormatException: 'Input string was not in a correct format.' (w przypadku int?)

            //   - ogromną liczbę, np. 9999999999999999999999999999999 
            //    System.OverflowException: 'Value was either too large or too small for an Int32.' (w przypadku int?)

            //   - liczbę 0 (dziala)

            //   - liczbę zmiennoprzecinkową, np. 2.5
            //    System.FormatException: 'Input string was not in a correct format.' (w przypadku int?)

            //  Wszystkie wypisane przypadki działają w programie (w przypadku var)
        }
    }
}
