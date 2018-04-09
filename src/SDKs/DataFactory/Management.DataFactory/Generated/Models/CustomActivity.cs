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
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Custom activity type.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Custom")]
    [Rest.Serialization.JsonTransformation]
    public partial class CustomActivity : ExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the CustomActivity class.
        /// </summary>
        public CustomActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="command">Command for custom activity Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="policy">Activity policy.</param>
        /// <param name="resourceLinkedService">Resource linked service
        /// reference.</param>
        /// <param name="folderPath">Folder path for resource files Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="referenceObjects">Reference objects</param>
        /// <param name="extendedProperties">User defined property bag. There
        /// is no restriction on the keys or values that can be used. The user
        /// specified custom activity has the full responsibility to consume
        /// and interpret the content defined.</param>
        public CustomActivity(string name, object command, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), LinkedServiceReference linkedServiceName = default(LinkedServiceReference), ActivityPolicy policy = default(ActivityPolicy), LinkedServiceReference resourceLinkedService = default(LinkedServiceReference), object folderPath = default(object), CustomActivityReferenceObject referenceObjects = default(CustomActivityReferenceObject), IDictionary<string, object> extendedProperties = default(IDictionary<string, object>))
            : base(name, additionalProperties, description, dependsOn, linkedServiceName, policy)
        {
            Command = command;
            ResourceLinkedService = resourceLinkedService;
            FolderPath = folderPath;
            ReferenceObjects = referenceObjects;
            ExtendedProperties = extendedProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets command for custom activity Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.command")]
        public object Command { get; set; }

        /// <summary>
        /// Gets or sets resource linked service reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.resourceLinkedService")]
        public LinkedServiceReference ResourceLinkedService { get; set; }

        /// <summary>
        /// Gets or sets folder path for resource files Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.folderPath")]
        public object FolderPath { get; set; }

        /// <summary>
        /// Gets or sets reference objects
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.referenceObjects")]
        public CustomActivityReferenceObject ReferenceObjects { get; set; }

        /// <summary>
        /// Gets or sets user defined property bag. There is no restriction on
        /// the keys or values that can be used. The user specified custom
        /// activity has the full responsibility to consume and interpret the
        /// content defined.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.extendedProperties")]
        public IDictionary<string, object> ExtendedProperties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Command == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Command");
            }
            if (ResourceLinkedService != null)
            {
                ResourceLinkedService.Validate();
            }
        }
    }
}
