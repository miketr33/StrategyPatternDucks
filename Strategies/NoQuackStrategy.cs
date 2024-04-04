using StrategyPatternDucks.Strategies.Interfaces;

namespace StrategyPatternDucks.Strategies
{
    /// <summary>
    /// Implementation of the IQuackStrategy interface. This is for no quacks (aka silent).
    /// </summary>
    internal class NoQuackStrategy : IQuackStrategy
    {
        public NoQuackStrategy() { }

        public void Quack()
        {
            Console.WriteLine("...");
        }
    }
}
