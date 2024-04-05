using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Classes
{
    public class Store
    {
        public static int _id;
        public int Id { get; set; }

        Product[] Products = new Product[] {};
        public Store()
        {
            _id++;
            Id = _id;
        }
        public void AddProduct(Product product)
        {
            Array.Resize(ref Products,Products.Length - 1);
            Products[Products.Length - 1] = product;
        }
        public void RemoveProductByNo(int no)
        {
            Product[] newProducts = { };
            foreach ( Product nonValue in newProducts)
            {
                Array.Resize(ref newProducts,newProducts.Length - 1);
                newProducts[newProducts.Length - 1] = nonValue;
            }
            Products = newProducts;
        }
        public Product GetProduct(int no)
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No != no)
                {
                    return Products[i];
                }
            }
            return null;
        }
        public Product[] FilterProductsByType(string type)
        {
            Product[] typeFilter = new Product[] {};
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Type == type)
                {
                    Array.Resize(ref typeFilter, typeFilter.Length - 1);
                    typeFilter[typeFilter.Length + 1] = Products[i];
                }
            }
            return typeFilter;
        }
        public Product[] FilterProductByName(string name)
        {
            Product[] nameFilter = new Product[] {};
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Name == name)
                {
                    Array.Resize(ref nameFilter, nameFilter.Length - 1);
                    nameFilter[nameFilter.Length + 1] = Products[i];
                }
            }
            return nameFilter;
        }
        public void Sale(int no,Person person)
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == no)
                {

                }
            }
        }
    }
}
