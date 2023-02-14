using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gra FizzBuzz, Podaj liczbę: ");
            int userNumber = int.Parse(Console.ReadLine());

            FizzBuzzGame player1 = new FizzBuzzGame();
            Console.WriteLine(player1.FizzBuzz(userNumber));
        }
    }



    class FizzBuzzGame
    {
        public FizzBuzzGame()
        {
            Console.WriteLine("Podaj liczbę: ");
        }
        public string FizzBuzz(int input)
        {

            if (input % 5 == 0 && input % 3 == 0)
            {
                return "Fizz";

            }
            else if (input % 5 == 0)
            {
                return "Buzz";

            }
            else if (input % 3 == 0)
            {
                return "FizzBuzz";

            }
            else
            {
                return input.ToString();

            }


        }
    }
}