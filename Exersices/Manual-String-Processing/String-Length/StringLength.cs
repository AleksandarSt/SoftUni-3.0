using System;
using System.Text;

namespace String_Length
{
    class StringLength
    {
        static void Main()
        {
            const int MaxLength = 20;

            StringBuilder input=new StringBuilder();
            input.Append(Console.ReadLine());

            if (input.Length>=MaxLength)
            {
                Console.WriteLine(input.ToString().Substring(0,MaxLength));
            }
            else
            {
                Console.Write(input.ToString());

                for (int i = 0; i < MaxLength-input.Length; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
