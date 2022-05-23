using System;
using CardClasses;

namespace CardTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestingConstructors();
            TestingGetters();
            TestingSetters();
            TestingBools();
        }

        static void TestingConstructors()
        {
            Card c1 = new Card();
            Card c2 = new Card(11, 1);

            Console.WriteLine("Expecting nothing: " + c1.ToString());
            Console.WriteLine("Expecting Jack of Clubs: " + c2.ToString());
        }

        static void TestingGetters()
        {
            // Gets and validates value for card
            Console.Write("Please enter what value you want the card to be: ");
            string valueInput = Console.ReadLine();
            int valNum = ValidNum(ref valueInput, 13);
            // Gets and validates the suit of the card
            Console.Write("Please enter what suit you want the card to be: ");
            string suitInput = Console.ReadLine();
            int suitNum = ValidNum(ref suitInput, 4);
            Card c1 = new Card(valNum, suitNum);

            Console.WriteLine("Expecting: " + valueInput + " of " + suitInput);
            Console.WriteLine(c1.ToString());
        }

        static void TestingSetters()
        {
            //Builds a card to later have it's values changed
            Card c1 = new Card(5, 3);

            c1.Value = 7;
            c1.Suit = 2;

            Console.WriteLine("Expecting 7 of Diamonds: " + c1.ToString());
        }

        static int ValidNum(ref string s, int max)
        {
            //Takes in string and sees if it can be parsed
            bool valid = false;
            do
            {
                int num = 0;
                if (int.TryParse(s, out num) != false && (int.Parse(s) >= 1 && int.Parse(s) <= max))
                    return num = int.Parse(s);
                else
                {
                    Console.Write("That is an invalid number, please try again: ");
                    s = Console.ReadLine();
                }
            } while (!valid);

            return 0;
        }

        static void TestingBools()
        {
            //Tests each appropriate bool function within the Card class displaying expected value and given value
            Card c1 = new Card(1, 1);
            Card c2 = new Card(11, 2);
            Console.Write("Expecting False for Isface: ");
            Console.WriteLine(c1.IsFaceCard());
            Console.Write("Expecting True for Isface: ");
            Console.WriteLine(c2.IsFaceCard());

            Console.Write("Expecting False for IsRed: ");
            Console.WriteLine(c1.IsRed());
            Console.Write("Expecting True for IsRed: ");
            Console.WriteLine(c2.IsRed());

            Console.Write("Expecting True for IsBlack: ");
            Console.WriteLine(c1.IsBlack());
            Console.Write("Expecting False for IsBlack: ");
            Console.WriteLine(c2.IsBlack());

            Console.Write("Expecting False for IsDiamond: ");
            Console.WriteLine(c1.IsDiamond());
            Console.Write("Expecting True for IsDiamond: ");
            Console.WriteLine(c2.IsDiamond());

            Console.Write("Expecting True for IsClub: ");
            Console.WriteLine(c1.IsClub());
            Console.Write("Expecting False for IsClub: ");
            Console.WriteLine(c2.IsClub());

            Console.Write("Expecting True for IsAce: ");
            Console.WriteLine(c1.IsAce());
            Console.Write("Expecting False for IsAce: ");
            Console.WriteLine(c2.IsAce());
        }
    }
}
