﻿using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        
        [StringLength(50)]
        public string Name { get; set; }
        public double Calori { get; set; }
        public ProductType productType { get; set; }

    }
}
