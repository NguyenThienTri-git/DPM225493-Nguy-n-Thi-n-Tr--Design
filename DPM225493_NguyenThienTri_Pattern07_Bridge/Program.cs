using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern07_Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();
            
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();
            
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();
            
            Console.ReadKey();
        }
    }
}
