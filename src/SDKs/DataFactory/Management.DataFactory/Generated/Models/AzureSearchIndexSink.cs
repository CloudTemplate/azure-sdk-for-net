// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A copy activity Azure Search Index sink.
    /// </summary>
    public partial class AzureSearchIndexSink : CopySink
    {
        /// <summary>
        /// Initializes a new instance of the AzureSearchIndexSink class.
        /// </summary>
        public AzureSearchIndexSink()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureSearchIndexSink class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="writeBatchSize">Write batch size. Type: integer (or
        /// Expression with resultType integer), minimum: 0.</param>
        /// <param name="writeBatchTimeout">Write batch timeout. Type: string
        /// (or Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="sinkRetryCount">Sink retry count. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="sinkRetryWait">Sink retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="writeBehavior">Specify the write behavior when
        /// upserting documents into Azure Search Index. Possible values
        /// include: 'Merge', 'Upload'</param>
        public AzureSearchIndexSink(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object writeBatchSize = default(object), object writeBatchTimeout = default(object), object sinkRetryCount = default(object), object sinkRetryWait = default(object), string writeBehavior = default(string))
            : base(additionalProperties, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait)
        {
            WriteBehavior = writeBehavior;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specify the write behavior when upserting documents
        /// into Azure Search Index. Possible values include: 'Merge', 'Upload'
        /// </summary>
        [JsonProperty(PropertyName = "writeBehavior")]
        public string WriteBehavior { get; set; }

    }
}
