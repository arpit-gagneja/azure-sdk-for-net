// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Details about the pod identity assigned to the Managed Cluster. </summary>
    public partial class ManagedClusterPodIdentity
    {
        /// <summary> Initializes a new instance of ManagedClusterPodIdentity. </summary>
        /// <param name="name"> The name of the pod identity. </param>
        /// <param name="namespace"> The namespace of the pod identity. </param>
        /// <param name="identity"> The user assigned identity details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="namespace"/> or <paramref name="identity"/> is null. </exception>
        public ManagedClusterPodIdentity(string name, string @namespace, ContainerServiceUserAssignedIdentity identity)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (@namespace == null)
            {
                throw new ArgumentNullException(nameof(@namespace));
            }
            if (identity == null)
            {
                throw new ArgumentNullException(nameof(identity));
            }

            Name = name;
            Namespace = @namespace;
            Identity = identity;
        }

        /// <summary> Initializes a new instance of ManagedClusterPodIdentity. </summary>
        /// <param name="name"> The name of the pod identity. </param>
        /// <param name="namespace"> The namespace of the pod identity. </param>
        /// <param name="bindingSelector"> The binding selector to use for the AzureIdentityBinding resource. </param>
        /// <param name="identity"> The user assigned identity details. </param>
        /// <param name="provisioningState"> The current provisioning state of the pod identity. </param>
        /// <param name="provisioningInfo"></param>
        internal ManagedClusterPodIdentity(string name, string @namespace, string bindingSelector, ContainerServiceUserAssignedIdentity identity, ManagedClusterPodIdentityProvisioningState? provisioningState, ManagedClusterPodIdentityProvisioningInfo provisioningInfo)
        {
            Name = name;
            Namespace = @namespace;
            BindingSelector = bindingSelector;
            Identity = identity;
            ProvisioningState = provisioningState;
            ProvisioningInfo = provisioningInfo;
        }

        /// <summary> The name of the pod identity. </summary>
        public string Name { get; set; }
        /// <summary> The namespace of the pod identity. </summary>
        public string Namespace { get; set; }
        /// <summary> The binding selector to use for the AzureIdentityBinding resource. </summary>
        public string BindingSelector { get; set; }
        /// <summary> The user assigned identity details. </summary>
        public ContainerServiceUserAssignedIdentity Identity { get; set; }
        /// <summary> The current provisioning state of the pod identity. </summary>
        public ManagedClusterPodIdentityProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the provisioning info. </summary>
        internal ManagedClusterPodIdentityProvisioningInfo ProvisioningInfo { get; }
        /// <summary> Details about the error. </summary>
        public ResponseError ErrorDetail
        {
            get => ProvisioningInfo?.ErrorDetail;
        }
    }
}
