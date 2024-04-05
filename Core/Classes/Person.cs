using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Classes
{
    public class Person
    {
        private int _id;
        public static int Id { get; set; } 
        public string FullName { get; set; }
        private sbyte _age;
        public int Cash { get; set; }

        public sbyte Age
        {
            get
            {
                return _age; 
            }
            set 
            {
                if (value > 0 || value <= 125)
                {
                    _age = value;
                }
            }
        }
        public Person( string fullName, sbyte age, int cash)
        {
            _id++;
            Id = _id;
            FullName = fullName;
            Age = age;
            Cash = cash;
            Age = age;
        }

        public virtual string ToString()
        {
            return $"Id:{Id}\n FullName:{FullName}\n Age:{Age}\n Cash{Cash}";
        }
    }
}
