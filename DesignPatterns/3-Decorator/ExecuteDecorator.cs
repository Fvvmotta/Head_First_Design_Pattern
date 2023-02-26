using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._3_Decorator
{
    public class ExecuteDecorator
    {
        public static void Execute()
        {
            Beverage beverage = new Expresso();
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            Beverage beverageTwo = new HouseBlend();
            beverageTwo = new Mocha(beverageTwo);
            beverageTwo = new Mocha(beverageTwo);
            beverageTwo = new Whip(beverageTwo); 
            Console.WriteLine(beverageTwo.GetDescription() + " $" + beverageTwo.Cost());

            Beverage beverageThree = new Decaf();
            beverageThree = new Soy(beverageThree);
            beverageThree = new Mocha(beverageThree);
            beverageThree = new Whip(beverageThree);
            beverageThree = new MilkFoam(beverageThree);
            Console.WriteLine(beverageThree.GetDescription() + " $" + beverageThree.Cost());

        }
    }
}
