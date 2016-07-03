﻿using System;
using Mankind.Models;

namespace Mankind
{
    class MankindStartup
    {
        static void Main()
        {
            string[] studentArgs = Console.ReadLine().Split();
            string[] workerArgs = Console.ReadLine().Split();

            try
            {
                Student student = new Student(studentArgs[0], studentArgs[1], studentArgs[2]);
                Worker worker =
                    new Worker
                        (
                        workerArgs[0],
                        workerArgs[1],
                        decimal.Parse(workerArgs[2]),
                        int.Parse(workerArgs[3])
                        );

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
