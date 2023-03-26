using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ModernChair : IChair
    {
        public string Buy()
        {
            return "Thank you for buying modern chair from us we hope you have nice time ^_^";
        }
    }
}
