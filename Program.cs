using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzGame player1 = new FizzBuzzGame();
            
            while (true)
            {
                Console.WriteLine("\njeśli chcesz wyjść z porgramu wpisz 'x' oraz zatwierdź enter\nPodaj kolejną liczbę:  ");
                int userNumber = GetValue();
                Console.WriteLine(player1.FizzBuzz(userNumber));
                Console.WriteLine();
            }
        }

        private static int GetValue()
        {
            while (true)
            {
                var val=Console.ReadLine();
                if (val.ToUpper()=="X")
                    Environment.Exit(0);

                if (!int.TryParse(val, out int valid))
                {
                    Console.WriteLine("Zła wartość,podaj liczbę. Spróbuj ponownie: ");
                    continue;
                }
                return valid;
            }
        }
    }

    class FizzBuzzGame
    {
        public FizzBuzzGame()
        {
            Console.WriteLine("Gra FizzBuzz");
        }

        public string FizzBuzz(int input)
        {
            if ((input % 5 == 0) && (input % 3 == 0))
                return "FizzBuzz";
            else if (input % 5 == 0)
                return "Buzz";
            else if (input % 3 == 0)
                return "Fizz";
            else
                return input.ToString();
        }
    }
}




            
            

            

            
            

            





            
            





