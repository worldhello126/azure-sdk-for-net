// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Intrusion detection bypass traffic specification.
    /// </summary>
    public partial class FirewallPolicyIntrusionDetectionBypassTrafficSpecifications
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FirewallPolicyIntrusionDetectionBypassTrafficSpecifications class.
        /// </summary>
        public FirewallPolicyIntrusionDetectionBypassTrafficSpecifications()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// FirewallPolicyIntrusionDetectionBypassTrafficSpecifications class.
        /// </summary>
        /// <param name="name">Name of the bypass traffic rule.</param>
        /// <param name="description">Description of the bypass traffic
        /// rule.</param>
        /// <param name="protocol">The rule bypass protocol. Possible values
        /// include: 'TCP', 'UDP', 'ICMP', 'ANY'</param>
        /// <param name="sourceAddresses">List of source IP addresses or ranges
        /// for this rule.</param>
        /// <param name="destinationAddresses">List of destination IP addresses
        /// or ranges for this rule.</param>
        /// <param name="destinationPorts">List of destination ports or
        /// ranges.</param>
        /// <param name="sourceIpGroups">List of source IpGroups for this
        /// rule.</param>
        /// <param name="destinationIpGroups">List of destination IpGroups for
        /// this rule.</param>
        public FirewallPolicyIntrusionDetectionBypassTrafficSpecifications(string name = default(string), string description = default(string), string protocol = default(string), IList<string> sourceAddresses = default(IList<string>), IList<string> destinationAddresses = default(IList<string>), IList<string> destinationPorts = default(IList<string>), IList<string> sourceIpGroups = default(IList<string>), IList<string> destinationIpGroups = default(IList<string>))
        {
            Name = name;
            Description = description;
            Protocol = protocol;
            SourceAddresses = sourceAddresses;
            DestinationAddresses = destinationAddresses;
            DestinationPorts = destinationPorts;
            SourceIpGroups = sourceIpGroups;
            DestinationIpGroups = destinationIpGroups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the bypass traffic rule.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets description of the bypass traffic rule.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the rule bypass protocol. Possible values include:
        /// 'TCP', 'UDP', 'ICMP', 'ANY'
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets list of source IP addresses or ranges for this rule.
        /// </summary>
        [JsonProperty(PropertyName = "sourceAddresses")]
        public IList<string> SourceAddresses { get; set; }

        /// <summary>
        /// Gets or sets list of destination IP addresses or ranges for this
        /// rule.
        /// </summary>
        [JsonProperty(PropertyName = "destinationAddresses")]
        public IList<string> DestinationAddresses { get; set; }

        /// <summary>
        /// Gets or sets list of destination ports or ranges.
        /// </summary>
        [JsonProperty(PropertyName = "destinationPorts")]
        public IList<string> DestinationPorts { get; set; }

        /// <summary>
        /// Gets or sets list of source IpGroups for this rule.
        /// </summary>
        [JsonProperty(PropertyName = "sourceIpGroups")]
        public IList<string> SourceIpGroups { get; set; }

        /// <summary>
        /// Gets or sets list of destination IpGroups for this rule.
        /// </summary>
        [JsonProperty(PropertyName = "destinationIpGroups")]
        public IList<string> DestinationIpGroups { get; set; }

    }
}