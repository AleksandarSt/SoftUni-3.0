using System;
using System.Collections.Generic;

namespace Fix_emails
{
    class FixEmails
    {
        static void Main()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            string name = Console.ReadLine();
            string email;

            do
            {


                if (name == "stop")
                {
                    break;
                }

                email = Console.ReadLine();
                string lastSymbols = email.Substring(email.Length - 3, 3);

                if (lastSymbols != ".us" && lastSymbols != ".uk")
                {
                    if (!dictionary.ContainsKey(name))
                    {
                        dictionary.Add(name, email);
                    }
                    else
                    {
                        dictionary[name] = email;
                    }
                }

                name = Console.ReadLine();
            } while (name != "stop" || email != "stop");

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
