using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            performDuck(mallardDuck);
            Duck redheadDuck = new RedheadDuck();
            performDuck(redheadDuck);
            Duck decoyDuck = new DecoyDuck();
            performDuck(decoyDuck);
            Duck rubberDuck = new RubberDuck();
            performDuck(rubberDuck);
        }

        public static void performDuck(Duck duck)
        {
            duck.PerformQuack();
            duck.PerformFly();
            duck.Swim();
            duck.Display();
        }
    }
}