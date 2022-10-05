using System.Linq.Expressions;

namespace Dice_roller_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of sides your die will have between 1-6?");
            int sides = Convert.ToInt32(Console.ReadLine());
            if (sides <= 6)
            {
                Console.WriteLine("Enter 'roll' to start");
                string start = Console.ReadLine();
                Random r = new Random();


                while (start == "y" || start == "roll")
                {
                    int FirstRoll = RollResult(sides, r);
                    int SecondRoll = RollResult(sides, r);
                    Console.WriteLine(FirstRoll + "\n" + SecondRoll);
                    if (FirstRoll == 1 && SecondRoll == 1)
                    {
                        Console.WriteLine("Snake Eyes!");
                    }
                    else if (FirstRoll == 6 && SecondRoll == 6)
                    {
                        Console.WriteLine("Boxcars!");
                    }
                    else if (FirstRoll + SecondRoll == 2 && FirstRoll + SecondRoll == 3 && FirstRoll + SecondRoll == 12)
                    {
                        Console.WriteLine("Craps!");
                    }
                    else if (FirstRoll == 1 && SecondRoll == 2)
                    {
                        Console.WriteLine("Ace Duece!");
                    }
                    else if (FirstRoll + SecondRoll == 7 && FirstRoll + SecondRoll == 11)
                    {
                        Console.WriteLine("You win!");
                    }


                    Console.WriteLine("\n Roll again? (y/n)");
                    start = Console.ReadLine();



                }

            }
            else
            {
                Console.WriteLine("that isn't within the range");
                return;
            }





        }
        public static int RollResult(int sides, Random r)
        {
            return r.Next(1, sides + 1);
        }
    }

}