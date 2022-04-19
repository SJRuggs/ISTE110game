using System;
using System.Threading;

namespace ISTE110game
{
    class Program
    {
        #region Main <----------------------<<<<
        static void Main(string[] args)
        {
            PrintIntro();
            switch (AskQuestion("Asking a Question?", new string[] { "option one", "option two", "option three" }))
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;
            }
        }
        #endregion

        #region Helper Methods <------------<<<<
        private static void PrintIntro()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Every day, millions of teenagers browse the internet.");
            Thread.Sleep(3000);

            Console.WriteLine("And every day, many of those teenagers are subject to online");
            Console.WriteLine("harrassment and bullying.");
            Thread.Sleep(3000);

            Console.Write("\nImagine you are one of those teenagers on the internet");
            Thread.Sleep(1000);
            for (int i = 0; i < 3; i++)
            {
                Console.Write(" .");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
        }

        private static int AskQuestion(string question, string[] options)
        {
            string answer;

            // print question and bracket
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(question);
            while (true)
            {
                Thread.Sleep(3000);

                // print answers
                Console.Write("\nDo you...   ");
                Thread.Sleep(1000);
                for (int i = 0; i < options.Length; i++)
                {
                    Console.Write("(" + (i + 1) + ") " + options[i].ToUpper());
                    Thread.Sleep(1000);
                    if (i != options.Length - 1)
                    {
                        Console.Write(",   ");
                    }
                    else
                    {
                        Console.Write("\n > ");
                    }
                }

                // grab answer
                answer = Console.ReadLine();

                // run through all options
                for (int i = 0; i < options.Length; i++)
                {
                    if (answer.ToUpper() == options[i].ToUpper() || (int.TryParse(answer, out int o) && o < options.Length + 1 && o != 0))
                    {
                        // print bracket and return once acceptable answer is found
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
                        return i - 1;
                    }
                }

                // print error
                Console.WriteLine(answer.ToUpper() + " is not an available option.");
            }
        }
        #endregion
    }
}
