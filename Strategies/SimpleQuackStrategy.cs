using StrategyPatternDucks.Strategies.Interfaces;

namespace StrategyPatternDucks.Strategies
{
    /// <summary>
    /// A simple implementation of the IQuackStrategy interface.
    /// </summary>
    internal class SimpleQuackStrategy : IQuackStrategy
    {
        public SimpleQuackStrategy() { }

        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
