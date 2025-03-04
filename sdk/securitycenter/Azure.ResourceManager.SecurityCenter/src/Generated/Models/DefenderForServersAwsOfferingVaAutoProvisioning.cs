// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The Vulnerability Assessment autoprovisioning configuration. </summary>
    public partial class DefenderForServersAwsOfferingVaAutoProvisioning
    {
        /// <summary> Initializes a new instance of DefenderForServersAwsOfferingVaAutoProvisioning. </summary>
        public DefenderForServersAwsOfferingVaAutoProvisioning()
        {
        }

        /// <summary> Initializes a new instance of DefenderForServersAwsOfferingVaAutoProvisioning. </summary>
        /// <param name="enabled"> Is Vulnerability Assessment auto provisioning enabled. </param>
        /// <param name="configuration"> configuration for Vulnerability Assessment autoprovisioning. </param>
        internal DefenderForServersAwsOfferingVaAutoProvisioning(bool? enabled, DefenderForServersAwsOfferingVaAutoProvisioningConfiguration configuration)
        {
            Enabled = enabled;
            Configuration = configuration;
        }

        /// <summary> Is Vulnerability Assessment auto provisioning enabled. </summary>
        public bool? Enabled { get; set; }
        /// <summary> configuration for Vulnerability Assessment autoprovisioning. </summary>
        internal DefenderForServersAwsOfferingVaAutoProvisioningConfiguration Configuration { get; set; }
        /// <summary> The Vulnerability Assessment solution to be provisioned. Can be either &apos;TVM&apos; or &apos;Qualys&apos;. </summary>
        public VAAutoProvisioningType? VAAutoProvisioningType
        {
            get => Configuration is null ? default : Configuration.VAAutoProvisioningType;
            set
            {
                if (Configuration is null)
                    Configuration = new DefenderForServersAwsOfferingVaAutoProvisioningConfiguration();
                Configuration.VAAutoProvisioningType = value;
            }
        }
    }
}
