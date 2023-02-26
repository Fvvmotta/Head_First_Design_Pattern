using DesignPatterns._1_Strategy;
using DesignPatterns._2_Observer;

Console.WriteLine("Choose an operation:");
Console.WriteLine("------------------------");
Console.WriteLine("Behavioral Patterns");
Console.WriteLine("------------------------");
Console.WriteLine("1 - Chapter 1 - Strategy - SimUDuck");
Console.WriteLine("2 - Chapter 2 - Observer - WeatherStation");
Console.WriteLine("3 - Command");
Console.WriteLine("4 - Template");
Console.WriteLine("5 - Iterator");
Console.WriteLine("6 - State");
Console.WriteLine("------------------------");
Console.WriteLine("Structural Patterns");
Console.WriteLine("------------------------");
Console.WriteLine("7 - Decorator");
Console.WriteLine("8 - Adapter");
Console.WriteLine("9 - Facade");
Console.WriteLine("10 - Composite");
Console.WriteLine("11 - Proxy");
Console.WriteLine("12 - Composite");
Console.WriteLine("------------------------");
Console.WriteLine("Creational Patterns");
Console.WriteLine("------------------------");
Console.WriteLine("13 - Factory Method");
Console.WriteLine("14 - Abstract Factory");
Console.WriteLine("15 - Singleton");
Console.WriteLine("16 - Observer");
Console.WriteLine("------------------------");

var option = Console.ReadKey();

Console.WriteLine("");
Console.WriteLine("------------------------");
Console.WriteLine("");

switch (option.KeyChar)
{
    case '1':
        ExecuteStrategy.Execute();
        break;
    case '2':
        ExecuteObserver.Execute();
        break;
}

Console.ReadKey();
Console.Clear();
