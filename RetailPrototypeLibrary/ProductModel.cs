using System;
using System.Collections.Generic;
using System.Text;

namespace RetailPrototypeLibrary
{
    class ProductModel
    {
        public int ProductId { get; set; }

        /// <summary>
        /// The Product Name
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Shorthand name for the product
        /// </summary>
        public string ProductShortName { get; set; }

        /// <summary>
        /// Category or type of product
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Manufacturer or owning company of the product
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// Average cost of the product per base selling unit
        /// </summary>
        public decimal AverageCost { get; set; }

        /// <summary>
        /// Point system product value
        /// </summary>
        public int ProductPointValue { get; set; }

        /// <summary>
        /// Image URL, can also be locally saved
        /// </summary>
        public string ImageURL { get; set; }

        /// <summary>
        /// List of all possible selling units
        /// Should be based on main and sub selling units
        /// </summary>
        public List<SellingUnitModel> SellingUnits { get; set; }

    }
}
