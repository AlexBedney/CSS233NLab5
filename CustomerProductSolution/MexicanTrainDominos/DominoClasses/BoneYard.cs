using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoClasses
{
    public class BoneYard
    {
        private List<Domino> listOfDominos = new List<Domino>();

        public Domino this[int index]
        {
            get
            {
                return listOfDominos[index];
            }
            set
            {
                listOfDominos[index] = value;
            }
        }

        public int DominosRemaining
        {
            get
            {
                return listOfDominos.Count();
            }
        }

        public BoneYard() { }

        public BoneYard(int maxDots)
        {
            listOfDominos = new List<Domino>();
            //Loop goes to the max number of dots, but each first number of dots is input descending 
            for (int i = 0; i <= maxDots; i++)
            {
                for (int u = i; u >= 0; u--)
                {
                    Domino domino = new Domino(i, u);
                    listOfDominos.Add(domino);
                }
            }
        }

        public Domino Draw()
        {
            //returns the top domino in the boneyard
            return listOfDominos[DominosRemaining - 1];
        }

        public bool IsEmpty()
        {
            if (DominosRemaining == 0)
                return true;
            else
                return false;
        }

        public void Shuffle()
        {
            Random gen = new Random();
            // go through all of the cards in the deck
            for (int i = 0; i < DominosRemaining; i++)
            {
                // generate a random index
                int rnd = gen.Next(0, DominosRemaining);
                // swap the card at the random index with the card at the current index
                Domino d = listOfDominos[rnd];
                listOfDominos[rnd] = listOfDominos[i];
                listOfDominos[i] = d;
            }
        }

        public override string ToString()
        {
            string output = "";
            foreach(Domino d in listOfDominos)
            {
                output += d.ToString() + "\n";
            }
            return "Boneyard: " + output;
        }
    }
}
