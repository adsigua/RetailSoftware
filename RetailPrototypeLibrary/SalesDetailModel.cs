using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace RetailPrototypeLibrary
{
    /// <summary>
    /// Class for each entry in a sales object
    /// </summary>
    class SalesDetailModel
    {
        public int SalesDetailId { get; set; }
        public string SellingUnitName { get; set; }
        public decimal SellingQuantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
