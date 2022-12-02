namespace DesignPattern.StrategyPattern.Esempio2Duck
{
    public class Program
    {
        static void Main()
        {

            IFlyBehavior fb = new StandardFlying();
            IQuackBehavior qb = new StandardQuack();
            Duck paperaStandard = new Duck(fb, qb);
            paperaStandard.Quack();
            paperaStandard.Fly();

            IFlyBehavior nofly = new NoFlying();
            IQuackBehavior squeeze = new Squeeze();
            Duck paperaSpecial = new Duck(nofly, squeeze );
            paperaSpecial.Quack();
            paperaSpecial.Fly();

            //MallardDuck sanCrispino = new MallardDuck();
            //Console.WriteLine(sanCrispino.PerformQuack());
            //Console.WriteLine(sanCrispino.PerformFly());

            //Duck sanCrispino = new MallardDuck();
            //Console.WriteLine(sanCrispino.PerformQuack());
           
            

        }
    }
}