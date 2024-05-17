using ShirtShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShirtShop.Cons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tshirt tshirt = new Tshirt
            {
                Brand = Brands.TommyHilfiger,
                Department = Departments.Adults,
                Fabric = Fabrics.Cotton,
                Gender = Genders.F,
                Size = Sizes.L,
                Type = Types.Tanktop,
                Id = Guid.NewGuid(),
                Colors = new List<Colors> { Colors.Blue, Colors.Red }
            };

            // alle properties van een T-shirt in een array 
            PropertyInfo[] properties = tshirt.GetType().GetProperties();

            // foreach die alle properties toont in console
            foreach (var property in properties) 
            { 
                if (property.Name != "Colors")
                {
                    Console.WriteLine(property.Name + " : "
                                + property.GetValue(tshirt));
                }
                else
                {
                    foreach (var item in tshirt.Colors)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
