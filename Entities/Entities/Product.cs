using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Calori { get; set; }
        public ProductType productType { get; set; }
        public double Gram { get; set; }

    }
}
