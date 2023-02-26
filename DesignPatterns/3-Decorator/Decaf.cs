namespace DesignPatterns._3_Decorator
{
    public class Decaf : Beverage
    {
        public Decaf(){}
        public override double Cost()
        {
            return 1.05;
        }
        public override string GetDescription()
        {
            return "Decaffeinated Coffee";
        }
    }
}
