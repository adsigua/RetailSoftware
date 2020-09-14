using System;
using System.Collections.Generic;
using System.Text;

namespace RetailPrototypeLibrary
{
    class DispatchModel
    {
        public int DispatchId { get; set; }

        /// <summary>
        /// Name of the selling unit used for dispatch
        /// </summary>
        public string SellingUnitName { get; set; }
        public decimal DispatchQuantity { get; set; }
        public string DispatchDate { get; set; }

    }
}
