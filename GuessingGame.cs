using System;
using System.Collections.Generic;
using System.Text;

namespace example
{
    class GuessingGame
    {
        public void Play()
        {
            Random r = new Random();
            int secretNumber = r.Next(101);
                
            bool guessed = false;
            while (!guessed)
            {
                Console.WriteLine("Please Enter next number");
                string answer = Console.ReadLine();
                bool success = Int32.TryParse(answer, out int num);
                while (!success) 

                {

                            Console.WriteLine("Please provide number");
                            answer = Console.ReadLine();
                            success = Int32.TryParse(answer, out num);
                    
                }
                if (num == secretNumber)
                {
                    Console.WriteLine("Congratulations, you won the Game");
                    guessed = true;
                }
                else if(num < secretNumber)
                {
                    Console.WriteLine("secretNumber is bigger than " + num);
                }
                else
                {
                    Console.WriteLine("secretNumber is less than " + num);
                }
            }
        }
    }
}
