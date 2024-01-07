using System;

namespace Random_zahleli
{
    class Program
    {
        static void Main()
        {
            int bestScore = int.MaxValue; // Initialize with a high value to start
            string playerName = "";
            
            while (true) // Keep the game running indefinitely
            {
                int versuch = 0;
                int Zahl = new Random().Next(1, 100);
                Console.WriteLine("A number was generated");
                int Eingabe = 0;
                string nochmals;

                while (Eingabe != Zahl)
                {
                    try
                    {
                        Start:
                        Console.WriteLine("Enter a number between 1 and 100.");
                        Eingabe = Convert.ToInt32(Console.ReadLine());
                        versuch = versuch + 1;

                        if (Zahl == Eingabe)
                        {
                            Console.WriteLine("Richtig");
                            Console.WriteLine("Du hast " + versuch + " Versuche gebraucht.");
                            
                            if (versuch < bestScore)
                            {
                                Console.Write("Congratulations! You've set a new high score! Enter your name: ");
                                playerName = Console.ReadLine();
                                bestScore = versuch;
                            }
                            
                            Console.WriteLine("Dein bisheriger Highscore: " + bestScore + " Versuche von " + playerName);
                            
                            Console.WriteLine("Willst du nochmals spielen? (y|n)");
                            nochmals = Console.ReadKey().KeyChar.ToString();

                            if (nochmals == "y")
                            {
                                Console.WriteLine(); // Add a new line before restarting
                                break; // Break out of the inner loop to restart the game
                            }
                            else
                            {
                                Console.WriteLine("Game over. Bye!");
                                return; // Exit the program
                            }
                        }
                        else
                        {
                            if (Zahl > Eingabe)
                            {
                                Console.WriteLine("Too small, think bigger");
                            }
                            else
                            {
                                Console.WriteLine("Too big, think smaller");
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error");
                    }

                }
            }
        }
    }
}
