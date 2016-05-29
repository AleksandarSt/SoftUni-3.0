using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Text_Editor
{
    public class SimpleTextEditor
    {
        static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            Stack<string> stack=new Stack<string>();
            stack.Push("");

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] currentCommand = Console.ReadLine().Split();
                StringBuilder text = new StringBuilder();

                switch (currentCommand[0])
                {
                    case "1":
                        text.Append(stack.Peek());
                        text.Append(currentCommand[1]);
                        stack.Push(text.ToString());
                        break;
                    case "2":
                        text.Append(stack.Peek());
                        text.Remove(text.Length - int.Parse(currentCommand[1]), int.Parse(currentCommand[1]));
                        stack.Push(text.ToString());
                        break;
                    case "3":
                        text.Append(stack.Peek());
                        Console.WriteLine(text[int.Parse(currentCommand[1]) - 1]);
                        break;
                    case "4":
                        stack.Pop();
                        break;
                }
            }

        }
    }
}
