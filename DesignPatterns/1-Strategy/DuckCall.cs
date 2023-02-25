using DesignPatterns._1_Strategy.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._1_Strategy
{
    public class DuckCall
    {
        public IQuackBehavior QuackBehavior { get; set; }

        public DuckCall()
        {
            QuackBehavior = new SoundQuack();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void Display()
        {
            Console.WriteLine("Iam a Duck Call!");
        }
    }
}
