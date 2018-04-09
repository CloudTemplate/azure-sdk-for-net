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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An object to provide order by options for listing pipeline runs.
    /// </summary>
    public partial class PipelineRunQueryOrderBy
    {
        /// <summary>
        /// Initializes a new instance of the PipelineRunQueryOrderBy class.
        /// </summary>
        public PipelineRunQueryOrderBy()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PipelineRunQueryOrderBy class.
        /// </summary>
        /// <param name="orderBy">Parameter name to be used for order by.
        /// Possible values include: 'RunStart', 'RunEnd'</param>
        /// <param name="order">Sorting order of the parameter. Possible values
        /// include: 'ASC', 'DESC'</param>
        public PipelineRunQueryOrderBy(string orderBy, string order)
        {
            OrderBy = orderBy;
            Order = order;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets parameter name to be used for order by. Possible
        /// values include: 'RunStart', 'RunEnd'
        /// </summary>
        [JsonProperty(PropertyName = "orderBy")]
        public string OrderBy { get; set; }

        /// <summary>
        /// Gets or sets sorting order of the parameter. Possible values
        /// include: 'ASC', 'DESC'
        /// </summary>
        [JsonProperty(PropertyName = "order")]
        public string Order { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (OrderBy == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OrderBy");
            }
            if (Order == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Order");
            }
        }
    }
}
