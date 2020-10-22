// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Management.Network.Models
{
    /// <summary> Parameters to get network configuration diagnostic. </summary>
    public partial class NetworkConfigurationDiagnosticParameters
    {
        /// <summary> Initializes a new instance of NetworkConfigurationDiagnosticParameters. </summary>
        /// <param name="targetResourceId"> The ID of the target resource to perform network configuration diagnostic. Valid options are VM, NetworkInterface, VMSS/NetworkInterface and Application Gateway. </param>
        /// <param name="profiles"> List of network configuration diagnostic profiles. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceId"/> or <paramref name="profiles"/> is null. </exception>
        public NetworkConfigurationDiagnosticParameters(string targetResourceId, IEnumerable<NetworkConfigurationDiagnosticProfile> profiles)
        {
            if (targetResourceId == null)
            {
                throw new ArgumentNullException(nameof(targetResourceId));
            }
            if (profiles == null)
            {
                throw new ArgumentNullException(nameof(profiles));
            }

            TargetResourceId = targetResourceId;
            Profiles = profiles.ToList();
        }

        /// <summary> The ID of the target resource to perform network configuration diagnostic. Valid options are VM, NetworkInterface, VMSS/NetworkInterface and Application Gateway. </summary>
        public string TargetResourceId { get; }
        /// <summary> Verbosity level. </summary>
        public VerbosityLevel? VerbosityLevel { get; set; }
        /// <summary> List of network configuration diagnostic profiles. </summary>
        public IList<NetworkConfigurationDiagnosticProfile> Profiles { get; }
    }
}