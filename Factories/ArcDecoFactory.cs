using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Chairs;
using AbstractFactory.Sofas;

namespace AbstractFactory.Factories
{
    internal class ArcDecoFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ArcDecoChair();
        }

        public ISofa CreateSofa()
        {
            return new ArcDecoSofa();
        }
    }
}
