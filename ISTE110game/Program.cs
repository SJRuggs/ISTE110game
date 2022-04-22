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
            
            // question one
            switch (AskQuestion("As you're browsing the online page of a local community,\n" +
                                "you find someone spreading harmful rumors about someone\n" +
                                "you know.", 
                                new string[] { "Do nothing", 
                                               "Report the account spreading rumors", 
                                               "Let the victim and their family know, and let them handle it" }))
            {
                case 1: PrintText(new string[] { "The rumors about the victim were too harmful, and weren't dealt with.", 
                                                 "After a couple months, the victim moved away."});
                    break;

                case 2: PrintText(new string[] { "You reported the account and it was banned the next day.", 
                                                 "About a week later, you found another, recently made account\n" +
                                                 "doing the exact same thing as the first."});
                    break;

                case 3: PrintText(new string[] { "You contacted the victim and they knew who it was.",
                                                 "Next week, you see the account is banned, and the victim\n" +
                                                 "thanks you and lets you know it was dealt with in person."});
                    break;
            }
            
            // question two
            switch (AskQuestion("You find an embarrasing video of someone you don't know.\n" +
                                "There are many rude comments on the post.", 
                                new string[] { "Repost the video", 
                                               "Comment something funny", 
                                               "Comment and tell others it's not ok",
                                               "Report the video"}))
            {
                case 1: PrintText(new string[] { "The rumors about the victim were too harmful, and weren't dealt with.", 
                                                 "After a couple months, the victim moved away."});
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
                Console.WriteLine("\nDo you...   ");
                Thread.Sleep(1000);
                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine("(" + (i + 1) + ") " + options[i].ToUpper());
                    Thread.Sleep(1000);
                    if (i == options.Length - 1)
                    {
                        Console.Write("\n > ");
                    }
                }

                // grab answer
                answer = Console.ReadLine().ToUpper().Trim();

                // run through all options
                for (int i = 0; i < options.Length; i++)
                {
                    if (answer == options[i].ToUpper())
                    {
                        // print bracket and return once acceptable answer is found
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
                        return i + 1;
                    }
                    if (int.TryParse(answer, out int o) && o < options.Length + 1 && o > 0)
                    {
                        // print bracket and return once acceptable answer is found
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
                        return o;
                    }
                }

                // print error
                Console.WriteLine(answer.ToUpper() + " is not an available option.");
            }
        }

        private static void PrintText(string[] texts)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (string str in texts)
            {
                Console.WriteLine(str);
                Thread.Sleep(3000);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
        }
        #endregion
    }
}
