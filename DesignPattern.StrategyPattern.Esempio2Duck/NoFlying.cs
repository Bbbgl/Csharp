using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


//here is a concrete strategy
namespace DesignPattern.StrategyPattern.Esempio2Duck
{
    public class NoFlying : IFlyBehavior
    {
        public void Fly() => Console.WriteLine("I cannot fly");
    }
}
