using System;
using System.Collections.Generic;
using System.Text;

namespace RetailPrototypeLibrary
{
    /// <summary>
    /// This class represents a single selling unit of a product.
    /// All selling units must be based from a base selling Unit.
    /// If Base unit is set to the same selling unit, then the unit is considered a base selling unit
    /// </summary>
    class SellingUnitModel
    {
        public int SellingUnitId { get; set; }

        /// <summary>
        /// Name of the Selling unit
        /// </summary>
        public string SellingUnitName { get; set; }

        /// <summary>
        /// The number of base units for each selling unit.
        /// eg 1 BAG (selling) is 50 (quantity) KG(BASE).
        /// Can be fractional, eg 1/2KG (selling)
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// The unit base, this unit must exist, a null base
        /// unit or same id as the selling unit will make
        /// this selling unit a base selling unit.
        /// eg 1Kg(selling) of 1Kg(base)
        /// </summary>
        public string BaseUnitName { get; set; }
    }
}
