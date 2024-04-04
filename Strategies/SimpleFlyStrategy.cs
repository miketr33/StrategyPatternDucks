using StrategyPatternDucks.Strategies.Interfaces;

namespace StrategyPatternDucks.Strategies
{
    /// <summary>
    /// A simple implementation of the IFlyStrategy interface. Simple flapping.
    /// </summary>
    public class SimpleFlyStrategy : IFlyStrategy
    {
        public SimpleFlyStrategy(){ }

        public void Fly()
        {
            Console.WriteLine("Simple flying, flap flap flap.");
        }
    }
}
