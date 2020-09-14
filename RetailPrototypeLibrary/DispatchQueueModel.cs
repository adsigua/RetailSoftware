using System;
using System.Collections.Generic;
using System.Text;

namespace RetailPrototypeLibrary
{
    /// <summary>
    /// A class that handles all pending dispatches. Can be bypassed or ignored
    /// if user settings allow auto dispatching
    /// </summary>
    class DispatchQueueModel
    {
        public int DispatchQueueId { get; set; }
        public int SalesDetailId { get; set; }

        /// <summary>
        /// Number of Main Units Left for pickup/delivery
        /// </summary>
        public decimal DispatchMainBalance { get; set; }

        /// <summary>
        /// Number of Sub Unit left for pickup/delivery
        /// </summary>
        public decimal DispatchSubBalance { get; set; }

        /// <summary>
        /// List of all product dispatches for this dispatch queue/sales detail
        /// </summary>
        public List<DispatchModel> Dispatches { get; set; }

    }
}
