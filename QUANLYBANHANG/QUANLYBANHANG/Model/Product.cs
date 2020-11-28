using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.Model
{
    class Product
    {
        public int product_ID { get; set; }
        public string product_name { get; set; }
        public int catalog_ID { get; set; }
        public int amount { get; set; }
        public string price { get; set; }
        public string product_detail { get; set; }
        
    }
}
