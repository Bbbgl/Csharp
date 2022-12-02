using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StrategyPattern.Esempio2Duck
{
    public class StandardFlying : IFlyBehavior
    {
        public void Fly() => Console.WriteLine("volo normale");
    }
}
