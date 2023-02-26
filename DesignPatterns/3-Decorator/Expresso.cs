using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._3_Decorator
{
    public class Expresso : Beverage
    {
        public Expresso(){}
        public override double Cost()
        {
            return 1.99;
        }
        public override string GetDescription()
        {
            return "Expresso";
        }
    }
}
