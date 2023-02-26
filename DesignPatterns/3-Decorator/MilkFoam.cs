namespace DesignPatterns._3_Decorator
{
    public class MilkFoam : CondimentDecorator
    {
        Beverage beverage;
        public MilkFoam(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return .10 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Milk Foam";
        }
    }
}
