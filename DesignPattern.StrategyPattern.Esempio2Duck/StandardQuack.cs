using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StrategyPattern.Esempio2Duck
{
    public class StandardQuack : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("quakko normale");
    }
}
