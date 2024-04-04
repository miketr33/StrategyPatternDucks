using StrategyPatternDucks.Strategies.Interfaces;

namespace StrategyPatternDucks.Strategies
{
    /// <summary>
    /// Concrete class implementing the IDisplayStrategy interface for displaying as strings.
    /// </summary>
    internal class DisplayAsStringStrategy : IDisplayStrategy
    {
        public void Dislay()
        {
            Console.WriteLine("I am a duck!");
        }
    }
}
