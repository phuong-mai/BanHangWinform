using QUANLYBANHANG.DAL;
using QUANLYBANHANG.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.BLL
{
    class InvoiceBLL
    {
        private static InvoiceDAL obj = new InvoiceDAL();
        public DataTable GetAll()
        {
            return obj.GetAll();
        }
        public Invoice GetByID(string ID)
        {
            return obj.GetInvoiceByID(ID);
        }
        public InvoiceDetail GetDetailByID(string ID)
        {
            return obj.GetInvoiceDetailByID(ID);
        }
        public static void AddInvoice(Invoice invoice)
        {
            obj.AddInvoice(invoice);
        }
        public static void UpdateInvoice(Invoice invoice)
        {
            obj.UpdateInvoice(invoice);
        }
        public static void DeleteInvoice(String ID)
        {
            obj.DeleteInvoice(ID);
        }
    }
}
