﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
    }
}
