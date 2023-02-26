namespace DesignPatterns._3_Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend(){}
        public override double Cost()
        {
            return .89;
        }
        public override string GetDescription()
        {
            return "House Blend Coffee";
        }
    }
}
