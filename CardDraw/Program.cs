using System;

namespace CardDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a program that contains a deck of 
           cards and randomly draws one.You will need a
           Card class to store information about each 
           individual card.The Card class should have a 
           method that gives you the full card name like
           “2 of Hearts”. You will need a Deck class that
           contains an array of all the cards.The Deck class 
           will need a method to draw a random card.Your main
           method in the Program class should create a deck object, 
           draw a random card and display the value.
           */
            Console.WriteLine("Random card drawn is:");
            Deck deck = new Deck();

            Card drawnCard = deck.RandomDraw();

            Console.WriteLine(drawnCard.NameOfCard());

            Console.ReadLine();

        }
    }
    public class Card
    {

        public string Suit { get; set; }//property and method combined
        public string Value { get; set; }

        public Card(string suit, string value)//constructor, puts suit and value into card so not null
        {
            Suit = suit;
            Value = value;
        }

        public string NameOfCard()
        {
            return Value + " of " + Suit;
        }
    }
    public class Deck
    {
        public Card[] cards;

        public Deck()//constructor is specialized method
        {
            cards = new Card[52];
            string[] values = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            string[] suits = { "Clubs", "Spades", "Hearts", "Diamonds" };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    cards[i * 13 + j] = new Card(suits[i], values[j]);
                }
            }
        }
        public Card RandomDraw()
            {
                Random r = new Random();
                return cards[r.Next(52)];
            }

            


    

        
       

        


        
    }       
}





