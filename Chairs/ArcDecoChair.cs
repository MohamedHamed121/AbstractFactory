using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Chairs
{
    internal class ArcDecoChair : IChair
    {
        public string Buy()
        {
            return "Thank you for buying ArcDeco chair from us we hope you have nice time ^_^";
        }
    }
}
