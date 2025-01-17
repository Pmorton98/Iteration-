using System;

namespace While_Loops_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "MrMorton";
            string password = "pass123";
            string usersname;
            string pass;
            int attempts = 0;
            bool valid = false;

            do
            {
                bool loginCorrect = false;

                do
                {
                    Console.WriteLine("Enter your username:");
                    usersname = Console.ReadLine();

                    Console.WriteLine("Enter your password:");
                    pass = Console.ReadLine();

                    if (usersname == username && pass == password)
                    {
                        loginCorrect = true; // 
                        valid = true; // set valid to true to exit the outer loop

                    }
                    else
                    {
                        attempts++;
                        Console.WriteLine($"Incorrect username or password. Attempts remaining: {4 - attempts}");
                        if (attempts >= 4)
                        {
                            break; // exit the loop as too many attempts 
                        }
                    }
                } while (!loginCorrect && attempts < 4); // loop until login is correct or too many attempts

                if (valid)
                {
                    Console.WriteLine("Login successful");
                }
            } while (!valid && attempts < 4);

            if (!valid)
            {
                Console.WriteLine("Too many attempts. Account locked.");
            }
        }
    }
}
