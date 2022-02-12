using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OOPHW1
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Count;
        public static double TotalIncome=0;
        

        public Product (string name)
        {
            Name = name;
            Console.Write($"{Name} produktu yaradildi!\n");

        }

        public Product(string name, double price, int count):this(name)
        {
            Price= price;
            Count = count;
            Console.WriteLine($"{Name} produktu {Price} qiymetinde {Count} sayinda Anbara daxil oldu!");
        }

        public void Sell()
        {
            if (Count > 0)
            {
                TotalIncome += Price;
                Count--;
            }
            else
            {
                Console.WriteLine("Mehsuldan galmayib, satishi mumkun deyil!");
            }
        }

        public string Info()
        {
            return $"{Name} - {Price} - {Count}";
        }


        


    }
}
