// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Azure;
    using Management;
    using Compute;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes Windows configuration of the OS Profile.
    /// </summary>
    public partial class LinuxConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the LinuxConfiguration class.
        /// </summary>
        public LinuxConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the LinuxConfiguration class.
        /// </summary>
        /// <param name="disablePasswordAuthentication">Specifies whether
        /// password authentication should be disabled.</param>
        /// <param name="ssh">The SSH configuration for linux VMs.</param>
        public LinuxConfiguration(bool? disablePasswordAuthentication = default(bool?), SshConfiguration ssh = default(SshConfiguration))
        {
            DisablePasswordAuthentication = disablePasswordAuthentication;
            Ssh = ssh;
        }

        /// <summary>
        /// Gets or sets specifies whether password authentication should be
        /// disabled.
        /// </summary>
        [JsonProperty(PropertyName = "disablePasswordAuthentication")]
        public bool? DisablePasswordAuthentication { get; set; }

        /// <summary>
        /// Gets or sets the SSH configuration for linux VMs.
        /// </summary>
        [JsonProperty(PropertyName = "ssh")]
        public SshConfiguration Ssh { get; set; }

    }
}

