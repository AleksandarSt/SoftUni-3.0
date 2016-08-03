using Dependency_Inversion.Contracts;

namespace Dependency_Inversion.Strategies
{
    public class MultiplicationStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand*secondOperand;
        }
    }
}
