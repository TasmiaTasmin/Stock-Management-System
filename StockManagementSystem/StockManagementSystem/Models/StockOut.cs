﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class StockOut
    {
        public int ID { get; set; }
        public string Date { get; set; }
        public int Quantity { get; set; }
        public int ItemID { get; set; }
        public string Action { get; set; }
        public string ItemName { get; set; }
        public string CompanyName { get; set; }
    }
}
