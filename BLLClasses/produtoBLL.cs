﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendas.BLLClasses
{
    internal class produtoBLL
    {
        public int id { get; set; }
        public string name { get; set; }
        public int category { get; set; }
        public string description { get; set;}
        public double rate { get; set;}
        public int gty { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }
}
