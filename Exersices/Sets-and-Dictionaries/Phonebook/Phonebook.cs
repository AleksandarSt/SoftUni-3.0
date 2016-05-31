using System;
using System.Collections.Generic;

namespace Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            Dictionary<string, string> phonebook=new Dictionary<string, string>();

            do
            {
                string line = Console.ReadLine();
                if (line=="search")
                {
                    break;
                }

                string currentKey=line.Split(new char[]{'-'},StringSplitOptions.RemoveEmptyEntries)[0];
                string currentValue = line.Split(new char[] {'-'}, StringSplitOptions.RemoveEmptyEntries)[1];

                if (!phonebook.ContainsKey(currentKey))
                {
                    phonebook.Add(currentKey,currentValue);
                }
                else
                {
                    phonebook[currentKey] = currentValue;
                }
            } while (true);

            do
            {
                string name = Console.ReadLine();

                if (name=="stop")
                {
                    break;
                }

                if (!phonebook.ContainsKey(name))
                {
                    Console.WriteLine("Contact {0} does not exist.",name);
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                }

            } while (true);
        }
    }
}
