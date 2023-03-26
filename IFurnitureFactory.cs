using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal interface IFurnitureFactory
    {
        public IChair CreateChair();
        public ISofa CreateSofa();
        
    }
}
