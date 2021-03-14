﻿using System;

namespace LensPokerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Hand[] hands = new Hand[4];
            Hand winner = null;

            deck.ShuffleDeck();

            for (int i = 0; i < hands.Length; i++)
            {
                hands[i] = new Hand(deck);
                Console.WriteLine("Hand {0}", i + 1);
                hands[i].PrintHand();
                Console.WriteLine();

                if (winner == null || hands[i] > winner)
                {
                    winner = hands[i];
                }
            }

            Console.WriteLine("-------------------\nWinning Hand:\n");
            winner.PrintHand();
        }
    }
}
