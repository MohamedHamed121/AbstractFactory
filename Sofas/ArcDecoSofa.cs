using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Sofas
{
    internal class ArcDecoSofa : ISofa
    {
        public string Buy()
        {
            return "Thank you for buying victorial sofa from us we hope you have nice time ^_^";
        }
    }
}
