using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace DesignPattern.StrategyPattern.Esempio2Duck
{
    public class Duck : IFlyBehavior, IQuackBehavior
    {   
        //here is dipendency injection for behavior variables, no hardcoded in
         IFlyBehavior fb;
         IQuackBehavior qb;


        //here is constructor of duck, with argument
        public Duck(IFlyBehavior fb, IQuackBehavior qb)
        {
            // in the constructor we set the behaviors arguments with the behavior variables
            this.fb = fb;
            this.qb = qb;
        }

        //implementations of interfaces
        public void Fly()
        {

            this.fb.Fly();
        }
        public void Quack()
        {
            this.qb.Quack();
        }
    }
}
