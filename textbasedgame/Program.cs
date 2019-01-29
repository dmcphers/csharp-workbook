using System;

namespace textbasedgame
{
    class Program
    {
        static void Main(string[] args)
        {
            // assign variables
            string ch1;
            string ch2;
            string ch3;
            string ch4;
            string ch5;
            int stick;
            int complete = 0;
            bool alive = true;


            while (alive == true)
            {
                // introduction to the game
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Welcome to the cavern of secrets!");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                System.Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor. Do you take it? [y/n]");
                ch1 = Console.ReadLine();

                // Stick taken
                if (ch1 == "y" || ch1 == "Y" || ch1 == "Yes" || ch1 == "YES" || ch1 == "yes")
                {
                    System.Console.WriteLine("You have chosen the stick!");
                    stick = 1;
                } 
                else
                {
                    // Stick not taken
                    System.Console.WriteLine("You have not chosen the stick!");
                    stick = 0;
                }

                // continue with adventure
                System.Console.WriteLine("As you proceed further into the cave, you see a small glowing object. Do you approach the object? [y/n]");
                ch2 = Console.ReadLine();

                // Approach spider
                if (ch2 == "y" || ch2 == "Y" || ch2 == "Yes" || ch2 == "YES" || ch2 == "yes")
                {
                    System.Console.WriteLine("You approach the object...");
                    System.Console.WriteLine("As you draw closer, you realize the object has an eye!");
                    System.Console.WriteLine("The eye belongs to a giant spider! Do you try to fight it? [Y/N]");
                    ch3 = Console.ReadLine();

                    // Fight Spider
                    if (ch3 == "y" || ch3 == "Y" || ch3 == "Yes" || ch3 == "YES" || ch3 == "yes")
                    {

                            //Fight spider with stick
                            if (stick == 1)
                            {
                                System.Console.WriteLine("You only have a stick to fight with!");
                                System.Console.WriteLine("You quickly jab the spider in the eye and gain an advantage");
                                System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                System.Console.WriteLine("                     Fighting...                           ");
                                System.Console.WriteLine("     YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER             ");
                                System.Console.WriteLine("     IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE      ");
                                System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                
                                Random rnd = new Random();

                                int playerdamage = rnd.Next(1,8);
                                int spiderdamage = rnd.Next(1,5);

                                System.Console.WriteLine("You hit a {0}", playerdamage);
                                System.Console.WriteLine("Spider hits a {0}", spiderdamage);

                                if (spiderdamage > playerdamage)
                                {
                                    // spider deals more damage than you
                                    System.Console.WriteLine("The spider has dealt more damage than you!"); 
                                    complete = 0;
                                }
                                else if (playerdamage <= 5)
                                {
                                    // you didn't do enough damage to kill spider but enough to escape
                                    System.Console.WriteLine("You didn't do enough damage to kill the spider, but you managed to escape!");
                                    complete = 1;
                                }
                                else
                                {
                                    // you killed the spider
                                    System.Console.WriteLine("You killed the spider!");
                                    complete = 1;
                                }
                            }
                            // Fight spider without stick
                            else 
                            {
                                System.Console.WriteLine("You don't have anything to fight with!");
                                System.Console.WriteLine("You quickly jab the spider in the eye and gain an advantage");
                                System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                System.Console.WriteLine("                     Fighting...                           ");
                                System.Console.WriteLine("     YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER             ");
                                System.Console.WriteLine("     IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE      ");
                                System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                
                                Random rnd = new Random();

                                int playerdamage = rnd.Next(1,8);
                                int spiderdamage = rnd.Next(1,5);

                                System.Console.WriteLine("You hit a {0}", playerdamage);
                                System.Console.WriteLine("Spider hits a {0}", spiderdamage);

                                if (spiderdamage > playerdamage)
                                {
                                    // spider has dealt more damage than you
                                    System.Console.WriteLine("The spider has dealt more damage than you!"); 
                                    complete = 0;
                                }
                                else if (playerdamage <= 5)
                                {
                                    // you didn't do enough damage to kill spider but enough to escape
                                    System.Console.WriteLine("You didn't do enough damage to kill the spider, but you managed to escape!");
                                    complete = 1;
                                }
                                else
                                {
                                    // you killed the spider
                                    System.Console.WriteLine("You killed the spider!");
                                    complete = 1;
                                }
                            }         
                    }
                    else
                    // Don't fight the spider
                    {
                    System.Console.WriteLine("You choose not to fight the spider.");
                    System.Console.WriteLine("As you turn away, the spider impales you with it's fangs!");
                    complete = 0;
                    }
                }
                else
                // Don't approach the spider
                {
                    Console.WriteLine("You turn away from the glowing object, and attempt to leave the cave...");
                    Console.WriteLine("But something won't let you...");
                    complete = 0;
                }

                        // Game Loop
                        if (complete == 1)
                        {
                            Console.WriteLine("You managed to escape the cavern alive! Would you like to play again? [y/n]:");
                            ch4 = Console.ReadLine();
                            if (ch4 == "y" || ch4 == "Y" || ch4 == "Yes" || ch4 == "YES" || ch4 == "yes")
                            {
                                // If user chooses to play again it loops back to the start
                                alive = true;
                            }
                            else
                            {
                                alive = false;
                                break;
                            } 
                        }
                        else
                        {
                            Console.WriteLine("You have been killed! Would you like to play again?[y/n]:");
                            ch5 = Console.ReadLine();
                            if (ch5 == "y" || ch5 == "Y" || ch5 == "Yes" || ch5 == "YES" || ch5 == "yes")
                            {
                                // If user chooses to play again it loops back to the start
                                alive = true;
                            }
                            else
                            {
                                // user chooses not to play again and program terminates
                                alive = false;
                                break;
                            } 
                        }
            }
        }
    }
}
