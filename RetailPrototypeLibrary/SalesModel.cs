using System;
using System.Collections.Generic;
using System.Text;

namespace RetailPrototypeLibrary
{
    class SalesModel
    {
        public int SalesId { get; set; }

        /// <summary>
        /// Document number for the sales
        /// </summary>
        public string InvoiceNumber { get; set; }
        public string EmployeeFirstName { get; set; }
        public string InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string CustomerName { get; set; }
        public List<SalesDetailModel> SalesList { get; set; }
    }
}
