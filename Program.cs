using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace blindsort_cmd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("How many numbers should be entered: ");
                Console.ResetColor();

                int adet = Convert.ToInt32(Console.ReadLine());

                int[] kisim = new int[adet];
                Random rnd = new Random();

                for (int i = 0; i < adet; i++)
                {
                    int sayi = rnd.Next(1, 51);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n" + sayi + "\n");
                    Console.ResetColor();

                    Console.Write(sayi + " which position should it be placed in (1-" + adet + "): ");
                    int sira = Convert.ToInt32(Console.ReadLine());

                    kisim[sira - 1] = sayi;

                    // Diziyi göster
                    Console.SetCursorPosition(0, adet);
                    for (int j = 0; j < adet; j++)
                    {
                        if (kisim[j] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("- ");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(kisim[j] + " ");
                        }
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                }

                bool lost = false;
                for (int j = 0; j < adet - 1; j++)
                {
                    if (kisim[j] > kisim[j + 1])
                    {
                        lost = true;
                        break;
                    }
                }

                if (lost)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou lost");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nCongratulations, you won");
                }
                Console.ResetColor();

                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You did not enter a number");
                Console.ResetColor();

                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
