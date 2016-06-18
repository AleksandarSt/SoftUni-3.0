using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Exam_Problems
{
    class JediMeditation
    {
        static void Main()
        {
            int inputLines = int.Parse(Console.ReadLine());

            Queue<string> mastersQueue=new Queue<string>();
            Queue<string> knightsQueue = new Queue<string>();
            Queue<string> padwansQueue = new Queue<string>();
            Queue<string> tarikatsQueue = new Queue<string>();

            bool isYodaHere = false;

            for (int i = 0; i < inputLines; i++)
            {
                string line = Console.ReadLine();

                string[] jedi = line.Split();

                for (int j = 0; j < jedi.Length; j++)
                {
                    string currentJedi = jedi[j];

                    switch (currentJedi[0])
                    {
                        case 'm':
                            mastersQueue.Enqueue(currentJedi);
                            break;
                        case 'k':
                            knightsQueue.Enqueue(currentJedi);
                            break;
                        case 'p':
                            padwansQueue.Enqueue(currentJedi);
                            break;
                        case 't':
                        case 's':
                            tarikatsQueue.Enqueue(currentJedi);
                            break;
                        case 'y':
                            isYodaHere = true;
                            break;
                    }
                }
            }

            StringBuilder result = new StringBuilder();

            if (isYodaHere)
            {
                

                result.Append(string.Join(" ",mastersQueue));
                result.Append(" ");
                result.Append(string.Join(" ", knightsQueue));
                result.Append(" ");
                result.Append(string.Join(" ", tarikatsQueue));
                result.Append(" ");
                result.Append(string.Join(" ", padwansQueue));

            }
            else
            {
                result.Append(string.Join(" ", tarikatsQueue));
                result.Append(" ");
                result.Append(string.Join(" ", mastersQueue));
                result.Append(" ");
                result.Append(string.Join(" ", knightsQueue));
                result.Append(" ");
                result.Append(string.Join(" ", padwansQueue));
            }

            Console.WriteLine(result.ToString().Trim());
        }
    }
}
