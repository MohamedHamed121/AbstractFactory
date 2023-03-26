using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class VictorianChair : IChair
    {
        public string Buy()
        {
            return "Thank you for buying victorian chair from us we hope you have nice time ^_^";
        }
    }
}
