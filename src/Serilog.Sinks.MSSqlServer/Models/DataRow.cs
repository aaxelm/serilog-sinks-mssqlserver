#if NETCORE
namespace Serilog.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// DataRow is a class used as a helper to implement a very limited DataTable like API.
    /// </summary>
    public class DataRow : Dictionary<string, object>
    {
        /// <summary>
        /// Constructs a case insensitive DataRow.
        /// </summary>
        public DataRow() : base(StringComparer.OrdinalIgnoreCase)
        {
        }
        /// <summary>
        /// Accessor for the DataTable of this row.
        /// </summary>
        public DataTable Table { get; set; }
    }
}
#endif