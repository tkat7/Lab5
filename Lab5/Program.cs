using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean cont = false;
            int x = 1;
            Random rnd = new Random();
            do
            {
                cont = false;
                Console.WriteLine("How many sides are on the dice?");
                string inpt = Console.ReadLine();
                int sides = int.Parse(inpt);
                int roll1, roll2;
                roll1 = DiceRoll(sides, rnd);
                roll2 = DiceRoll(sides, rnd);
                Console.WriteLine("Roll "+x+":");
                Console.WriteLine(roll1);
                Console.WriteLine(roll2);
                Console.WriteLine();


                Console.Write("Roll again? (y/n)");
                string input = Console.ReadLine();
                if (input == "y" || input == "Y")
                {
                    cont = true;
                }
                x++;
            } while (cont == true);
        }

        public static int DiceRoll(int die, Random rnd)
        {

            int roll = rnd.Next(die - 1);
            roll = roll + 1;
            return roll;
        }


    }
}
