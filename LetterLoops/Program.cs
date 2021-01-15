using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string.");
            string input = Console.ReadLine();

            var charIndex = 0;
            for (var c = 0; c < input.Length; c++)
            {
                Console.Write($"{input[c].ToString().ToUpper()}");

                while(true)
                {
                    
                    if (charIndex < c)
                    {
                        Console.Write($"{input[c].ToString()}");

                        charIndex++;
                        continue;
                    }
                    break;
                }

                if (c != input.Length - 1)
                {
                    Console.Write($"-");
                    charIndex = 0;
                }
                

                
            }

            



        }
    }
}
