using Dependency_Inversion.Contracts;

namespace Dependency_Inversion.Strategies
{
    class SubtractionStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand - secondOperand;
        }
    }
}
