using DesignPatterns._1_Strategy.Fly;
using DesignPatterns._1_Strategy.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._1_Strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new SoundQuack();
            FlyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("Iam a real Mallard duck!");
        }
    }
}
