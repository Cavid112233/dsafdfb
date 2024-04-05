using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Classes
{
    public class Product
    {
        private static int _no;
        public  int No {  get; set; }
        public string Name { get; set; }
        private double _price;

        public string Type { get; set; }
        public int Count { get; set; }
        public double Price 
        { 
            get 
            { 
                return _price; 
            } 
        
            set 
            { 
                if (value > 0)
                {
                    _price = value;
                }
                
            } 
        }
        public Product(string name,double _price,string type,int count)
        {
            _no++;
            No = _no;
            Name = name;
            Price = _price;
            Type = type;
            Count = count;
        }
        public override string ToString()
        {
            return $"No:{No} Name:{Name} Price:{Price} Type:{Type} Count:{Count}";
        }
    }
}
