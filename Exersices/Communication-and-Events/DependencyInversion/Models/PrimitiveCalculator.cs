using Dependency_Inversion.Contracts;
using Dependency_Inversion.Strategies;

namespace Dependency_Inversion.Models
{
    class PrimitiveCalculator
    {
        private IStrategy strategy;

        public PrimitiveCalculator(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public PrimitiveCalculator()
            :this (new AdditionStrategy())
        {
        }

        public void ChangeStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
        {
            return this.strategy.Calculate(firstOperand, secondOperand);
        }
    }
}
