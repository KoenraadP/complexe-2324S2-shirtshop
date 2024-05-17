using System;
using System.Collections.Generic;

namespace ShirtShop.Entities
{
    public class Tshirt
    {
        public Guid Id { get; set; }
        public Sizes Size { get; set; }
        public Genders Gender { get; set; }
        public Departments Department { get; set; }
        public List<Colors> Colors { get; set; }
        public Types Type { get; set; }
        public Fabrics Fabric { get; set; }
        public Brands Brand { get; set; }
    }
}
