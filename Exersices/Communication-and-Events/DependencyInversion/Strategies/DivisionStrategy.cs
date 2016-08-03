using Dependency_Inversion.Contracts;

namespace Dependency_Inversion.Strategies
{
    public class DivisionStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand/secondOperand;
        }
    }
}
