using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Program
    {
      
       static void Main(string[] args)
        {

            Random random = new Random();
            int randomnum = random.Next(1, 100);
            int Guess = 0;
            Console.WriteLine("I am thinking of a number between 1-100.  Can you guess what it is?");

            while (Guess != randomnum)
            {
                Guess = Int32.Parse(Console.ReadLine());

                if (Guess < randomnum)
                {
                    Console.WriteLine("No, the number I am thinking of is higher than " + Guess + ". Can you guess what it is?");
                }
                else if (Guess > randomnum)
                {
                    Console.WriteLine("No, the number I am thinking of is lower than " + Guess + ". Can you guess what it is?");
                }

            }

            Console.WriteLine("Well done! The answer was " + randomnum);
            Console.ReadKey
                ();
        }

    }

}