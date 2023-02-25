using DesignPatterns._1_Strategy.Fly;

namespace DesignPatterns._1_Strategy
{
    public class ExecuteStrategy
    {
        public static void Execute()
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();

            DuckCall call = new DuckCall();
            call.PerformQuack();
        }
    }
}
