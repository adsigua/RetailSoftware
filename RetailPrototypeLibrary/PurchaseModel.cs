using System;
using System.Collections.Generic;
using System.Text;

namespace RetailPrototypeLibrary
{
    /// <summary>
    /// Class that holds purchase data
    /// </summary>
    class PurchaseModel
    {
        public int PurchaseId { get; set; }
        
        /// <summary>
        /// Document number for the purchase
        /// </summary>
        public string PurchaseNumber { get; set; }
        public string PurchaseDate { get; set; }
        public string SupplierName { get; set; }
        public decimal TotalAmount { get; set; }
        public string PurchaseRemarks { get; set; }
        public List<PurchaseDetailModel> PurchaseList { get; set; }
    }
}
