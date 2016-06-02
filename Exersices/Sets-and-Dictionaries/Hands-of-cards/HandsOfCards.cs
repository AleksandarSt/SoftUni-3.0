using System;
using System.Collections.Generic;
using System.Linq;

namespace Hands_of_cards
{
    class HandsOfCards
    {
        static void Main()
        {
            Dictionary<string, HashSet<string>> dictionary=new Dictionary<string, HashSet<string>>();

            string line = Console.ReadLine();
            bool isJokerDrawnFirst = false;

            do
            {
                if (line=="JOKER")
                {
                    isJokerDrawnFirst = true;
                    break;
                }

                string[] splited = line.Split(new char[] {' ', ':', ','}, StringSplitOptions.RemoveEmptyEntries);
                HashSet<string> currentHashSet=new HashSet<string>();

                for (int i = 1 ; i < splited.Length; i++)
                {
                    currentHashSet.Add(splited[i]);
                }

                if (!dictionary.ContainsKey(splited[0]))
                {
                    dictionary.Add(splited[0],currentHashSet);
                }
                else
                {
                    dictionary[splited[0]].UnionWith(currentHashSet);
                }

                line = Console.ReadLine();

            } while (line!="JOKER");



            if (!isJokerDrawnFirst)
            {
                foreach (var pair in dictionary)
                {

                    Console.WriteLine("{0}: {1}"
                        , pair.Key
                        , pair.Value
                            .Sum
                            (
                                card =>
                                    CalculateCardPoints(card)
                            )
                        );
                }
            }
        }

        public static int CalculateCardPoints(string card)
        {
            int power = 0;
            int multiplier = 0;

            switch (card[0])
            {
                case '1':
                    power = 10;
                    break;
                case '2':
                    power = 2;
                    break;
                case '3':
                    power = 3;
                    break;
                case '4':
                    power = 4;
                    break;
                case '5':
                    power = 5;
                    break;
                case '6':
                    power = 6;
                    break;
                case '7':
                    power = 7;
                    break;
                case '8':
                    power = 8;
                    break;
                case '9':
                    power = 9;
                    break;
                case 'J':
                    power = 11;
                    break;
                case 'Q':
                    power = 12;
                    break;
                case 'K':
                    power = 13;
                    break;
                case 'A':
                    power = 14;
                    break;
            }

            switch (card[card.Length-1].ToString())
            {
                case "S":
                    multiplier = 4;
                    break;
                case "H":
                    multiplier = 3;
                    break;
                case "D":
                    multiplier = 2;
                    break;
                case "C":
                    multiplier = 1;
                    break;
            }

            var result = power*multiplier;

            return result;
        }

    }
}
