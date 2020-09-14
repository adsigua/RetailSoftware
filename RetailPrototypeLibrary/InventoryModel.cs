using System;
using System.Collections.Generic;
using System.Text;

namespace RetailPrototypeLibrary
{
    class InventoryModel
    {
        public int InventoryId { get; set; }
        public int ProductId { get; set; }


        /// <summary>
        /// Determines the type of transaction to consider for the Transaction Number
        /// </summary>
        public int TransactionType { get; set; }

        /// <summary>
        /// Document Number/Receipt Number/Invoice Number
        /// </summary>
        public string TransactionNumber { get; set; }

        /// <summary>
        /// Warehouse where the product will be stored or released
        /// </summary>
        public string WarehouseName { get; set; }
        public decimal InventoryQuantity { get; set; }

        /// <summary>
        /// The Name of Unit used for the transaction, based from either Main Unit or Base Unit
        /// </summary>
        public string UnitName { get; set; }
        public string InventoryDate { get; set; }
        
        /// <summary>
        /// Running Balance for the Main Unit (eg. BAG, CARTON)
        /// </summary>
        public decimal MainBalance { get; set; }

        /// <summary>
        /// Running Balance for the Sub Unit (eg. KILO, BOT)
        /// </summary>
        public decimal SubBalance { get; set; }

        /// <summary>
        /// Some Remarks about the details of transaction
        /// </summary>
        public string Remarks { get; set; }

    }
}
