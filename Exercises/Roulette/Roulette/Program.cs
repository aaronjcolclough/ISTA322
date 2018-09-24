using System;
using System.Linq;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Roulette");
            Console.WriteLine("Press enter to spin the wheel");
            Console.ReadLine();            

            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 00 };            
            int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };            
            
            doWork(numbers, red, black);
        }

        

        private static void doWork(int[] numbers, int[] red, int[] black)
        {            
            Random rnd = new Random();
            int spin = rnd.Next(0, numbers.Length);
            Console.WriteLine();
            Console.WriteLine($"Winning number is {numbers[spin]}");
            Console.WriteLine("Winners are:");

            if (numbers[spin] == 0 || numbers[spin] == 00)
            {
                Console.WriteLine("Row (Zeros)");
                Console.WriteLine("Basket (0, 00, 1, 2, 3)");
            }
            else
            {
                if (numbers[spin] % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }

                if (red.Contains(numbers[spin]))
                {
                    Console.WriteLine("Red");
                }
                else
                {
                    Console.WriteLine("Black");
                }

                if (numbers[spin] <= 18)
                {
                    Console.WriteLine("Lower 18");
                }
                else
                {
                    Console.WriteLine("Upper 18");
                }

                if (numbers[spin] <= 12)
                {
                    Console.WriteLine("Lower Third");
                }
                else if (numbers[spin] <= 24 && numbers[spin] > 12)
                {
                    Console.WriteLine("Middle Third");
                }
                else
                {
                    Console.WriteLine("Upper Third");
                }

                if (numbers[spin] % 3 == 1)
                {
                    Console.WriteLine("First Column");
                    Console.WriteLine($"Street: {numbers[spin]} / {numbers[spin] + 1} / {numbers[spin] + 2}");

                    if (numbers[spin] == 1)
                    {
                        Console.WriteLine("Split: 1 / 2 and 1 / 4");
                        Console.WriteLine("Six Line: 1 to 6");
                        Console.WriteLine("Corners: 1 / 2 / 4 / 5");
                        Console.WriteLine("Basket (0, 00, 1, 2, 3)");
                    }
                    else if (numbers[spin] == 34)
                    {
                        Console.WriteLine("Split: 31 / 34 and 34 / 35");
                        Console.WriteLine("Six Line: 31 to 36");
                        Console.WriteLine("Corners: 31 / 32 / 34 / 35");
                    }
                    else
                    {
                        Console.WriteLine($"Split: {numbers[spin] - 3} / {numbers[spin]}, {numbers[spin]} / {numbers[spin] + 1}, {numbers[spin]} / {numbers[spin] + 3}");
                        Console.WriteLine($"Six Line: {numbers[spin] - 3} to {numbers[spin] + 2} and {numbers[spin]} to {numbers[spin] + 5}");
                        Console.WriteLine($"Corners: {numbers[spin] - 3} / {numbers[spin] - 2} / {numbers[spin]} / {numbers[spin] + 1} and {numbers[spin]} / {numbers[spin] + 1} / {numbers[spin] + 3} / {numbers[spin] + 4}");
                    }                    
                }
                else if (numbers[spin] % 3 == 2)
                {
                    Console.WriteLine("Second Column");
                    Console.WriteLine($"Street: {numbers[spin] - 1} / {numbers[spin]} / {numbers[spin] + 1}");

                    if (numbers[spin] == 2)
                    {
                        Console.WriteLine("Split: 1 / 2, 2 / 3 and 2 / 5");
                        Console.WriteLine("Six Line: 1 to 6");
                        Console.WriteLine("Corners: 1 / 2 / 4 / 5 and 2 / 3 / 5 / 6");
                        Console.WriteLine("Basket (0, 00, 1, 2, 3)");
                    }
                    else if (numbers[spin] == 35)
                    {
                        Console.WriteLine("Split: 32 / 35, 34 / 35 and 35 / 36");
                        Console.WriteLine("Six Line: 31 to 36");
                        Console.WriteLine("Corners: 31 / 32 / 34 / 35 and 32 / 33 / 35 / 36");
                    }
                    else
                    {
                        Console.WriteLine($"Split: {numbers[spin] - 3} / {numbers[spin]}, {numbers[spin] - 1} / {numbers[spin]}, {numbers[spin]} / {numbers[spin] + 1}, {numbers[spin]} / {numbers[spin] + 3}");
                        Console.WriteLine($"Six Line: {numbers[spin] - 4} to {numbers[spin] + 1} and {numbers[spin] - 1} to {numbers[spin] + 4}");
                        Console.WriteLine($"Corners: {numbers[spin] - 4} / {numbers[spin] - 3} / {numbers[spin] - 1} / {numbers[spin]}, {numbers[spin] - 3} / {numbers[spin] - 2} / {numbers[spin]} / {numbers[spin] + 1}, {numbers[spin] - 1} / {numbers[spin]} / {numbers[spin] + 2} / {numbers[spin] + 3} and {numbers[spin]} / {numbers[spin] + 1} / {numbers[spin] + 3} / {numbers[spin] + 4}");
                    }
                }
                else
                {
                    Console.WriteLine("Third Column");
                    Console.WriteLine($"Street: {numbers[spin] - 2} / {numbers[spin] - 1} / {numbers[spin]}");

                    if (numbers[spin] == 3)
                    {
                        Console.WriteLine("Split: 2 / 3 and 3 / 6");
                        Console.WriteLine("Six Line: 1 to 6");
                        Console.WriteLine("Corners: 2 / 3 / 5 / 6");
                        Console.WriteLine("Basket (0, 00, 1, 2, 3)");
                    }
                    else if (numbers[spin] == 36)
                    {
                        Console.WriteLine("Split: 33 / 36 and 35 / 36");
                        Console.WriteLine("Six Line: 31 to 36");
                        Console.WriteLine("Corners: 32 / 33 / 35 / 36");
                    }
                    else
                    {
                        Console.WriteLine($"Split: {numbers[spin] - 3} / {numbers[spin]}, {numbers[spin] - 1} / {numbers[spin]}, {numbers[spin]} / {numbers[spin] + 3}");
                        Console.WriteLine($"Six Line: {numbers[spin] - 5} to {numbers[spin]} and {numbers[spin] - 2} to {numbers[spin] + 3}");
                        Console.WriteLine($"Corners: {numbers[spin] - 4} / {numbers[spin] - 3} / {numbers[spin] - 1} / {numbers[spin]} and {numbers[spin] - 1} / {numbers[spin]} / {numbers[spin] + 2} / {numbers[spin] + 3}");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Would you like to spin again? Yes or No");            
            playAgain(numbers, red, black);
        }

        private static void playAgain(int[] numbers, int[] red, int[] black)
        {            
            string again = Console.ReadLine();

            if (again.ToLower() == "yes")
            {
                doWork(numbers, red, black);
            }
            else if (again.ToLower() == "no")
            {
                Console.WriteLine("Thank you for playing, goodbye.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Are you drunk? I asked if you want to play again. Yes or No ");
                playAgain(numbers, red, black);
            }
        }
        
    }
}
