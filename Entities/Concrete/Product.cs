﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public int Stok { get; set; }

        public int CategoryId { get; set; }

        public decimal UnitPrice { get; set; }

    }
}
