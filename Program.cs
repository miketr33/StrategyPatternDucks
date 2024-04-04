using StrategyPatternDucks;
using StrategyPatternDucks.Strategies;

// To create a new duck we just configure one with certain properties.
Duck MallardDuck = new(new SimpleFlyStrategy(), new NoQuackStrategy(), new DisplayAsStringStrategy());
Duck CityDuck = new(new JetFlyStrategy(), new SimpleQuackStrategy(),new DisplayAsStringStrategy());
Duck WildDuck = new(new SimpleFlyStrategy(), new SimpleQuackStrategy(), new DisplayAsGraphicStrategy());

// Showing that ducks have been created and have different behaviours/strategies.
Console.WriteLine("\nMallard duck created. Executing behaviours...");
Console.WriteLine("[Flying]");
MallardDuck.Fly();
Console.WriteLine("\n[Quacking]");
MallardDuck.Quack();
Console.WriteLine("\n[Dislaying]");
MallardDuck.Display();

Console.WriteLine("\n\nCityDuck created. Executing behaviours...");
Console.WriteLine("[Flying]");
CityDuck.Fly();
Console.WriteLine("\n[Quacking]");
CityDuck.Quack();
Console.WriteLine("\n[Dislaying]");
CityDuck.Display();

Console.WriteLine("\n\nWildDuck created. Executing behaviours...");
Console.WriteLine("[Flying]");
WildDuck.Fly();
Console.WriteLine("\n[Quacking]");
WildDuck.Quack();
Console.WriteLine("\n[Dislaying]");
WildDuck.Display(); 

