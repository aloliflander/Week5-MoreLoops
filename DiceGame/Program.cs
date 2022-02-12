using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int userScore = 0;
            int cpuSCore = 0;

            for (int i = 0; i < 3; i++)
            {
              
                Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 7);
            int userRandom = rnd.Next(1, 7);
            Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");
          if(cpuRandom < userRandom)
                {
                    Console.WriteLine();
                    userScore = userScore +1;
                }
          else if(cpuRandom > userRandom)
                {
                    Console.WriteLine();
                    cpuSCore = cpuSCore + 1;
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Arvuti skoor on {cpuSCore}, kasutaja skoor on {userScore}");
            if(cpuSCore < userScore)
            {
                Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
            }
            else if(cpuSCore > userScore)
            {
                Console.WriteLine("Arvuti on mängu võitnud");
            }
            else
            {
                Console.WriteLine("Mäng on viigis");
            }

        }
    }
}
