using System;
using System.Collections.Generic;
using System.Text;

namespace User_logs
{
    class UserLogs
    {
        static void Main()
        {
            string[] command = Console.ReadLine().Split(new[] {' ', '='}, StringSplitOptions.RemoveEmptyEntries);

            SortedDictionary<string, Dictionary<string, int>> logsByUser =
                new SortedDictionary<string, Dictionary<string, int>>();

            while (command[0]!="end")
            {
                string ip = command[1];
                string user = command[5];


                if (!logsByUser.ContainsKey(user))
                {
                    logsByUser.Add(user, new Dictionary<string, int>());
                    logsByUser[user].Add(ip, 0);
                }
                else if (!logsByUser[user].ContainsKey(ip))
                {
                    logsByUser[user].Add(ip,0);
                }

                logsByUser[user][ip]++;

                command = Console.ReadLine().Split(new[] {' ', '='}, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var user in logsByUser)
            {
                Console.WriteLine("{0}:",user.Key);
                StringBuilder outputLine=new StringBuilder();
                foreach (var ip in user.Value)
                {
                    outputLine.AppendFormat("{0} => {1}, ", ip.Key, ip.Value);
                }
                outputLine.Remove(outputLine.Length - 2, 2);
                Console.WriteLine("{0}.",outputLine);
            }
        }
    }
}
