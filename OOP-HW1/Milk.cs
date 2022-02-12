using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW1
{
    internal class Milk: Product
    {
        public double Volume;
        public double FatRate;


        public Milk(string name):base(name)
        {

        }
        public Milk(string name, double price, int count,double volume,double fatRate) : base(name, price, count)
        {
            Volume = volume;
            FatRate = fatRate;
        }
        
        public string Info()
        {
            Console.Write(base.Info());
            return $"- {Volume}- {FatRate}";
        }

        
    }
}
