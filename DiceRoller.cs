using System;
using System.Collections.Generic;
using System.Text;

    public class DiceRoller
    {
        private readonly Random _random = new Random();

        public int[] RollDice(int rolls)
        {
            int[] results = new int[13];

            for (int i = 0; i < rolls; i++)
            {
                int die1 = _random.Next(1, 7);
                int die2 = _random.Next(1, 7);
                int sum = die1 + die2;

                results[sum]++; // in posiion of the numbner rolled add one to that position in the array
            }
            return results;
        }

    }
