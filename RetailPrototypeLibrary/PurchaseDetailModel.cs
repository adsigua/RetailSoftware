using System;
using System.Collections.Generic;
using System.Text;

namespace RetailPrototypeLibrary
{
    /// <summary>
    /// Class for each entry in a purchase object
    /// </summary>
    class PurchaseDetailModel
    {
        public int PurchaseDetailId { get; set; }
        public int PurchaseId { get; set; }
        public string SellingUnitId { get; set; }
        public decimal PurchaseQuantity { get; set; }
        public decimal UnitCost { get; set; }

    }
}