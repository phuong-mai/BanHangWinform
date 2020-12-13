using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.Model
{
    public class Invoice
    {
        public int ID { get; set; }
        public string Invoice_Name { get; set; }
        public int ID_Customer { get; set; }
        public int Shipper_ID { get; set; }
        public string totalMoney { get; set; }
        public DateTime createdDate { get; set; }
        public string customerAddress { get; set; }
        public DateTime shipDate { get; set; }
    }
}
