using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintCards
{
    static void Main(string[] args)
    {
        /*
         11. Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
             The cards should be printed with their English names. Use nested for loops and switch-case.
        */

        string cardName = "";

        for (int i = 2; i <= 14; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                switch (i)
                {
                    case 2: { cardName = "Deuce of "; }; break;
                    case 3: { cardName = "Three of "; }; break;
                    case 4: { cardName = "Four of "; }; break;
                    case 5: { cardName = "Five of "; }; break;
                    case 6: { cardName = "Six of "; }; break;
                    case 7: { cardName = "Seven of "; }; break;
                    case 8: { cardName = "Eight of "; }; break;
                    case 9: { cardName = "Nine of "; }; break;
                    case 10: { cardName = "Ten of "; }; break;
                    case 11: { cardName = "Jack of "; }; break;
                    case 12: { cardName = "Queen of "; }; break;
                    case 13: { cardName = "King of "; }; break;
                    case 14: { cardName = "Ace of "; }; break;
                    default: { cardName = ""; }; break;
                }

                switch (j)
                {
                    case 1: { cardName += "clubs"; }; break;
                    case 2: { cardName += "hearts"; }; break;
                    case 3: { cardName += "spades"; }; break;
                    case 4: { cardName += "diamonds"; }; break;
                    default: { cardName += ""; }; break;
                }

                Console.WriteLine(cardName);
                cardName = "";
            }
        }
    }
}
