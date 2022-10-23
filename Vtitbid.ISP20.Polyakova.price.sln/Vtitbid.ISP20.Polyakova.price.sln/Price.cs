using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Polyakova.price.sln
{
    public class Price
    {
        public string Name { get; set; }
        public string Shop { get; set; }
        public string Cost { get; set; }


        public Price(string name, string shop, string cost)
        {
            Name = name;
            Shop = shop;
            Cost = cost;
        }
        
        public override string ToString()
        {
            return $"Название товара: {Name}, Название магазина: {Shop}, Цена товара: {Cost} \n";
        }
    }
}
