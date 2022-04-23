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

            int peopleHelped = 0;
            int peopleHurt = 0;
            int karenPoints = 0;
            
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
                    peopleHurt++;
                    break;

                case 2: PrintText(new string[] { "You reported the account and it was banned the next day.", 
                                                 "About a week later, you found another, recently made account\n" +
                                                 "doing the exact same thing as the first."});
                    break;

                case 3: PrintText(new string[] { "You contacted the victim and they knew who it was.",
                                                 "Next week, you see the account is banned, and the victim\n" +
                                                 "thanks you and lets you know it was dealt with in person."});
                    peopleHelped++;
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
                case 1: PrintText(new string[] { "You got a couple upvotes, and a couple laughs, but at what cost?" });
                    peopleHurt++;
                    break;

                case 2:
                    PrintText(new string[] { "You got a couple upvotes, and a couple laughs, but at what cost?" });
                    peopleHurt++;
                    break;

                case 3:
                    PrintText(new string[] { "You got a couple downvotes and rude comments, but the post didn't\n" +
                                             "gain any more popularity." });
                    peopleHelped++;
                    break;

                case 4:
                    PrintText(new string[] { "You report the video, but nothing happens because" +
                                             "\nit didn't break any rules, it was just embarrasing.?" });
                    karenPoints += 100; // lol karen
                    break;
            }

            // question three
            switch (AskQuestion("You find an online account that seems to be owned\n" +
                                "by a friend of yours, but they things they post are\n" +
                                "very rude, and doesn't seem like your friend.",
                                new string[] { "Do nothing",
                                               "Talk to your friend"}))
            {
                case 1:
                    PrintText(new string[] { "After a couple months, the account continues to post rude things\n" +
                                             "and your friend moves away." });
                    peopleHurt++;
                    break;

                case 2:
                    PrintText(new string[] { "You find out it wasn't their account, then your friend reported it\n" +
                                             "and got it banned." });
                    peopleHelped++;
                    break;
            }

            // question four
            switch (AskQuestion("A group of people from your school is trying to bully you online.",
                                new string[] { "Do nothing",
                                               "Ask councelor or teacher for help",
                                               "Ask family for help",
                                               "Confront the bullies in person"}))
            {
                case 1:
                    PrintText(new string[] { "After a few months of online harrassment, your self\n" +
                                             "esteem drops, and you start doing badly in school, where\n" +
                                             "you almost excelled before." });
                    peopleHurt++;
                    break;

                case 2:
                    PrintText(new string[] { "You ask your councelor for help, and they talk to the bullies.\n" +
                                             "The harrassment stops for now, but you can see in their eyes\n" +
                                             "that they're not done with you..." });
                    break;

                case 3:
                    PrintText(new string[] { "You ask your family for help, and they do their best to support you.\n" +
                                             "The harrassment doesn't stop, but you pull through." });
                    break;

                case 4:
                    PrintText(new string[] { "You confront the bullies in person, and after showing some spine and\n" +
                                             "standing up for yourself, the bullies back down, and the harrassment stops." });
                    peopleHelped++;
                    break;
            }


            // print results
            Console.WriteLine("You managed to help {0} people, but hurt {1} people along the way.", peopleHelped, peopleHurt);

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
