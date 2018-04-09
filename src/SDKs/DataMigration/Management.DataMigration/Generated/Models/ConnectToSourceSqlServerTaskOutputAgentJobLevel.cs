// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// AgentJob level output for the task that validates connection to SQL
    /// Server and also validates source server requirements
    /// </summary>
    [Newtonsoft.Json.JsonObject("AgentJobLevelOutput")]
    public partial class ConnectToSourceSqlServerTaskOutputAgentJobLevel : ConnectToSourceSqlServerTaskOutput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConnectToSourceSqlServerTaskOutputAgentJobLevel class.
        /// </summary>
        public ConnectToSourceSqlServerTaskOutputAgentJobLevel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConnectToSourceSqlServerTaskOutputAgentJobLevel class.
        /// </summary>
        /// <param name="id">Result identifier</param>
        /// <param name="name">AgentJob name</param>
        /// <param name="jobCategory">The type of AgentJob.</param>
        /// <param name="isEnabled">The state of the original AgentJob.</param>
        /// <param name="jobOwner">The owner of the AgentJob</param>
        /// <param name="lastExecutedOn">UTC Date and time when the AgentJob
        /// was last executed.</param>
        /// <param name="migrationEligibility">Information about eligiblity of
        /// agent job for migration.</param>
        public ConnectToSourceSqlServerTaskOutputAgentJobLevel(string id = default(string), string name = default(string), string jobCategory = default(string), bool? isEnabled = default(bool?), string jobOwner = default(string), System.DateTimeOffset? lastExecutedOn = default(System.DateTimeOffset?), MigrationEligibilityInfo migrationEligibility = default(MigrationEligibilityInfo))
            : base(id)
        {
            Name = name;
            JobCategory = jobCategory;
            IsEnabled = isEnabled;
            JobOwner = jobOwner;
            LastExecutedOn = lastExecutedOn;
            MigrationEligibility = migrationEligibility;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets agentJob name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the type of AgentJob.
        /// </summary>
        [JsonProperty(PropertyName = "jobCategory")]
        public string JobCategory { get; private set; }

        /// <summary>
        /// Gets the state of the original AgentJob.
        /// </summary>
        [JsonProperty(PropertyName = "isEnabled")]
        public bool? IsEnabled { get; private set; }

        /// <summary>
        /// Gets the owner of the AgentJob
        /// </summary>
        [JsonProperty(PropertyName = "jobOwner")]
        public string JobOwner { get; private set; }

        /// <summary>
        /// Gets UTC Date and time when the AgentJob was last executed.
        /// </summary>
        [JsonProperty(PropertyName = "lastExecutedOn")]
        public System.DateTimeOffset? LastExecutedOn { get; private set; }

        /// <summary>
        /// Gets information about eligiblity of agent job for migration.
        /// </summary>
        [JsonProperty(PropertyName = "migrationEligibility")]
        public MigrationEligibilityInfo MigrationEligibility { get; private set; }

    }
}
