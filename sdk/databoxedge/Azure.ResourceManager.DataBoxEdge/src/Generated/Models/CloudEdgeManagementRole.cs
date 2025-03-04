// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary>
    /// The preview of Virtual Machine Cloud Management from the Azure supports deploying and managing VMs on your Azure Stack Edge device from Azure Portal. 
    /// For more information, refer to: https://docs.microsoft.com/en-us/azure/databox-online/azure-stack-edge-gpu-virtual-machine-overview
    /// By using this feature, you agree to the preview legal terms. See the https://azure.microsoft.com/en-us/support/legal/preview-supplemental-terms/ for additional details.
    /// </summary>
    public partial class CloudEdgeManagementRole : DataBoxEdgeRoleData
    {
        /// <summary> Initializes a new instance of CloudEdgeManagementRole. </summary>
        public CloudEdgeManagementRole()
        {
            Kind = RoleType.CloudEdgeManagement;
        }

        /// <summary> Initializes a new instance of CloudEdgeManagementRole. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Role type. </param>
        /// <param name="localManagementStatus"> Local Edge Management Status. </param>
        /// <param name="edgeProfile"> Edge Profile of the resource. </param>
        /// <param name="roleStatus"> Role status. </param>
        internal CloudEdgeManagementRole(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, RoleType kind, DataBoxEdgeRoleStatus? localManagementStatus, EdgeProfile edgeProfile, DataBoxEdgeRoleStatus? roleStatus) : base(id, name, resourceType, systemData, kind)
        {
            LocalManagementStatus = localManagementStatus;
            EdgeProfile = edgeProfile;
            RoleStatus = roleStatus;
            Kind = kind;
        }

        /// <summary> Local Edge Management Status. </summary>
        public DataBoxEdgeRoleStatus? LocalManagementStatus { get; }
        /// <summary> Edge Profile of the resource. </summary>
        internal EdgeProfile EdgeProfile { get; }
        /// <summary> Edge Profile Subscription. </summary>
        public EdgeProfileSubscription EdgeSubscription
        {
            get => EdgeProfile?.Subscription;
        }

        /// <summary> Role status. </summary>
        public DataBoxEdgeRoleStatus? RoleStatus { get; set; }
    }
}
