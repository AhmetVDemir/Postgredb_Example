﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        [Key]
        public int id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string City { get; set; }

    }
}
