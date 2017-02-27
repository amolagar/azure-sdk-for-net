// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// Display metadata associated with the operation.
    /// </summary>
    public partial class OperationDisplay
    {
        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        public OperationDisplay() { }

        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        /// <param name="provider">Service provider: Microsoft SQL
        /// Database.</param>
        /// <param name="resource">Resource on which the operation is
        /// performed: Server, Database, etc.</param>
        /// <param name="operation">Type of operation: get, read, delete,
        /// etc.</param>
        public OperationDisplay(string provider = default(string), string resource = default(string), string operation = default(string))
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
        }

        /// <summary>
        /// Gets or sets service provider: Microsoft SQL Database.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets resource on which the operation is performed: Server,
        /// Database, etc.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets type of operation: get, read, delete, etc.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

    }
}