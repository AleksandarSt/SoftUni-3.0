using System;
using Dependency_Inversion.Contracts;
using Dependency_Inversion.Models;
using Dependency_Inversion.Strategies;

namespace Dependency_Inversion
{
    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var calculator=new PrimitiveCalculator();

            while (input!="End")
            {
                string[] inputArgs = input.Split();

                if (inputArgs[0]=="mode")
                {
                    switch (inputArgs[1])
                    {
                        case "+":
                            IStrategy addition = new AdditionStrategy();
                            calculator.ChangeStrategy(addition);
                            break;
                        case "/":
                            IStrategy division = new DivisionStrategy();
                            calculator.ChangeStrategy(division);
                            break;
                        case "-":
                            IStrategy substraction = new SubtractionStrategy();
                            calculator.ChangeStrategy(substraction);
                            break;
                        case "*":
                            IStrategy multiplication = new MultiplicationStrategy();
                            calculator.ChangeStrategy(multiplication);
                            break;
                    }
                }
                else
                {
                    var firstOperand = int.Parse(inputArgs[0]);
                    var secondOperand = int.Parse(inputArgs[1]);
                    var result=calculator.PerformCalculation(firstOperand, secondOperand);

                    Console.WriteLine(result);
                }

                input = Console.ReadLine();
            }
        }
    }
}
