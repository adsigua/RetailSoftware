using System;
using System.Collections.Generic;
using System.Text;

namespace RetailPrototypeLibrary
{
    /// <summary>
    /// Class that holds each unit of measurement used for
    /// selling units.
    /// </summary>

    class UnitMeasurementModel
    {
        public int UnitId { get; set; }
        public string UnitName { get; set; }

        /// <summary>
        /// Unit abbreviation
        /// </summary>
        public string UnitShortName { get; set; }
    }
}
