﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Service.DTOs
{
    public class SauceUpdateDTO
    {
        public int Id { get; set; }
        public string SauceName { get; set; }
        public double SaucePrice { get; set; }
    }
}
