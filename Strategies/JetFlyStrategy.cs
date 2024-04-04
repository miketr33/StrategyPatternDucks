using StrategyPatternDucks.Strategies.Interfaces;

namespace StrategyPatternDucks.Strategies
{
    /// <summary>
    /// An implementation of the IFlyStrategy, used for ducks that fly with jets.
    /// </summary>
    internal class JetFlyStrategy : IFlyStrategy
    {
        public JetFlyStrategy() { }

        public void Fly()
        {
            Console.WriteLine("Jet flying activated! ZoOoOoOoM!");
        }
    }
}
