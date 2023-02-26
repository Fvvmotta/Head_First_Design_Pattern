namespace DesignPatterns._3_Decorator
{
    public class StrainedCoffee : Beverage
    {
        public StrainedCoffee(){}
        public override double Cost()
        {
            return .99;
        }
        public override string GetDescription()
        {
            return "Strained Coffee";
        }
    }
}
