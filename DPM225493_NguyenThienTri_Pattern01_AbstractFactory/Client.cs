using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern01_AbstractFactory
{
    internal class Client
    {
        private AbstractProduct1 _abstractproduct1;
        private AbstractProduct2 _abstractproduct2;
        public Client(AbstractFactory factory)
        {
            _abstractproduct2 = factory.CreateProductB();
            _abstractproduct1 = factory.CreateProductA();
        }
        public void Run()
        {
            _abstractproduct2.Interact(_abstractproduct1);
        }

    }
}
