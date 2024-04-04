using StrategyPatternDucks.Strategies.Interfaces;

namespace StrategyPatternDucks
{
    /// <summary>
    /// Super class used by all ducks. This implements the strategy pattern using composition instead of inheritance.
    /// Duck types can be created at runtime with whatever configurations you wish. There is no need to have sub class
    /// ducks that inherit this.
    /// </summary>
    public class Duck
    {
        private readonly IFlyStrategy _flyStrategy;

        private readonly IQuackStrategy _quackStrategy;

        private readonly IDisplayStrategy _displayStrategy;

        public Duck(IFlyStrategy flyStrategy, IQuackStrategy quackStrategy, IDisplayStrategy displayStrategy)
        {
            _flyStrategy = flyStrategy;
            _quackStrategy = quackStrategy;
            _displayStrategy = displayStrategy;
        }

        public void Fly()
        {
            _flyStrategy.Fly();
        }

        public void Display()
        {
            _displayStrategy.Dislay();
        }

        public void Quack()
        {
            _quackStrategy.Quack();
        }
    }
}
