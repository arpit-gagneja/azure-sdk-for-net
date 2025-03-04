// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> Policy state record. </summary>
    public partial class PolicyState
    {
        /// <summary> Initializes a new instance of PolicyState. </summary>
        internal PolicyState()
        {
            PolicyDefinitionGroupNames = new ChangeTrackingList<string>();
            Components = new ChangeTrackingList<ComponentStateDetails>();
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of PolicyState. </summary>
        /// <param name="odataId"> OData entity ID; always set to null since policy state records do not have an entity ID. </param>
        /// <param name="odataContext"> OData context string; used by OData clients to resolve type information based on metadata. </param>
        /// <param name="timestamp"> Timestamp for the policy state record. </param>
        /// <param name="resourceId"> Resource ID. </param>
        /// <param name="policyAssignmentId"> Policy assignment ID. </param>
        /// <param name="policyDefinitionId"> Policy definition ID. </param>
        /// <param name="effectiveParameters"> Effective parameters for the policy assignment. </param>
        /// <param name="isCompliant"> Flag which states whether the resource is compliant against the policy assignment it was evaluated against. This property is deprecated; please use ComplianceState instead. </param>
        /// <param name="subscriptionId"> Subscription ID. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="resourceLocation"> Resource location. </param>
        /// <param name="resourceGroup"> Resource group name. </param>
        /// <param name="resourceTags"> List of resource tags. </param>
        /// <param name="policyAssignmentName"> Policy assignment name. </param>
        /// <param name="policyAssignmentOwner"> Policy assignment owner. </param>
        /// <param name="policyAssignmentParameters"> Policy assignment parameters. </param>
        /// <param name="policyAssignmentScope"> Policy assignment scope. </param>
        /// <param name="policyDefinitionName"> Policy definition name. </param>
        /// <param name="policyDefinitionAction"> Policy definition action, i.e. effect. </param>
        /// <param name="policyDefinitionCategory"> Policy definition category. </param>
        /// <param name="policySetDefinitionId"> Policy set definition ID, if the policy assignment is for a policy set. </param>
        /// <param name="policySetDefinitionName"> Policy set definition name, if the policy assignment is for a policy set. </param>
        /// <param name="policySetDefinitionOwner"> Policy set definition owner, if the policy assignment is for a policy set. </param>
        /// <param name="policySetDefinitionCategory"> Policy set definition category, if the policy assignment is for a policy set. </param>
        /// <param name="policySetDefinitionParameters"> Policy set definition parameters, if the policy assignment is for a policy set. </param>
        /// <param name="managementGroupIds"> Comma separated list of management group IDs, which represent the hierarchy of the management groups the resource is under. </param>
        /// <param name="policyDefinitionReferenceId"> Reference ID for the policy definition inside the policy set, if the policy assignment is for a policy set. </param>
        /// <param name="complianceState"> Compliance state of the resource. </param>
        /// <param name="policyEvaluationDetails"> Policy evaluation details. </param>
        /// <param name="policyDefinitionGroupNames"> Policy definition group names. </param>
        /// <param name="components"> Components state compliance records populated only when URL contains $expand=components clause. </param>
        /// <param name="policyDefinitionVersion"> Evaluated policy definition version. </param>
        /// <param name="policySetDefinitionVersion"> Evaluated policy set definition version. </param>
        /// <param name="policyAssignmentVersion"> Evaluated policy assignment version. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal PolicyState(string odataId, string odataContext, DateTimeOffset? timestamp, ResourceIdentifier resourceId, ResourceIdentifier policyAssignmentId, ResourceIdentifier policyDefinitionId, string effectiveParameters, bool? isCompliant, string subscriptionId, string resourceType, AzureLocation? resourceLocation, string resourceGroup, string resourceTags, string policyAssignmentName, string policyAssignmentOwner, string policyAssignmentParameters, string policyAssignmentScope, string policyDefinitionName, string policyDefinitionAction, string policyDefinitionCategory, ResourceIdentifier policySetDefinitionId, string policySetDefinitionName, string policySetDefinitionOwner, string policySetDefinitionCategory, string policySetDefinitionParameters, string managementGroupIds, string policyDefinitionReferenceId, string complianceState, PolicyEvaluationDetails policyEvaluationDetails, IReadOnlyList<string> policyDefinitionGroupNames, IReadOnlyList<ComponentStateDetails> components, string policyDefinitionVersion, string policySetDefinitionVersion, string policyAssignmentVersion, IReadOnlyDictionary<string, BinaryData> additionalProperties)
        {
            OdataId = odataId;
            OdataContext = odataContext;
            Timestamp = timestamp;
            ResourceId = resourceId;
            PolicyAssignmentId = policyAssignmentId;
            PolicyDefinitionId = policyDefinitionId;
            EffectiveParameters = effectiveParameters;
            IsCompliant = isCompliant;
            SubscriptionId = subscriptionId;
            ResourceType = resourceType;
            ResourceLocation = resourceLocation;
            ResourceGroup = resourceGroup;
            ResourceTags = resourceTags;
            PolicyAssignmentName = policyAssignmentName;
            PolicyAssignmentOwner = policyAssignmentOwner;
            PolicyAssignmentParameters = policyAssignmentParameters;
            PolicyAssignmentScope = policyAssignmentScope;
            PolicyDefinitionName = policyDefinitionName;
            PolicyDefinitionAction = policyDefinitionAction;
            PolicyDefinitionCategory = policyDefinitionCategory;
            PolicySetDefinitionId = policySetDefinitionId;
            PolicySetDefinitionName = policySetDefinitionName;
            PolicySetDefinitionOwner = policySetDefinitionOwner;
            PolicySetDefinitionCategory = policySetDefinitionCategory;
            PolicySetDefinitionParameters = policySetDefinitionParameters;
            ManagementGroupIds = managementGroupIds;
            PolicyDefinitionReferenceId = policyDefinitionReferenceId;
            ComplianceState = complianceState;
            PolicyEvaluationDetails = policyEvaluationDetails;
            PolicyDefinitionGroupNames = policyDefinitionGroupNames;
            Components = components;
            PolicyDefinitionVersion = policyDefinitionVersion;
            PolicySetDefinitionVersion = policySetDefinitionVersion;
            PolicyAssignmentVersion = policyAssignmentVersion;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> OData entity ID; always set to null since policy state records do not have an entity ID. </summary>
        public string OdataId { get; }
        /// <summary> OData context string; used by OData clients to resolve type information based on metadata. </summary>
        public string OdataContext { get; }
        /// <summary> Timestamp for the policy state record. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> Resource ID. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> Policy assignment ID. </summary>
        public ResourceIdentifier PolicyAssignmentId { get; }
        /// <summary> Policy definition ID. </summary>
        public ResourceIdentifier PolicyDefinitionId { get; }
        /// <summary> Effective parameters for the policy assignment. </summary>
        public string EffectiveParameters { get; }
        /// <summary> Flag which states whether the resource is compliant against the policy assignment it was evaluated against. This property is deprecated; please use ComplianceState instead. </summary>
        public bool? IsCompliant { get; }
        /// <summary> Subscription ID. </summary>
        public string SubscriptionId { get; }
        /// <summary> Resource type. </summary>
        public string ResourceType { get; }
        /// <summary> Resource location. </summary>
        public AzureLocation? ResourceLocation { get; }
        /// <summary> Resource group name. </summary>
        public string ResourceGroup { get; }
        /// <summary> List of resource tags. </summary>
        public string ResourceTags { get; }
        /// <summary> Policy assignment name. </summary>
        public string PolicyAssignmentName { get; }
        /// <summary> Policy assignment owner. </summary>
        public string PolicyAssignmentOwner { get; }
        /// <summary> Policy assignment parameters. </summary>
        public string PolicyAssignmentParameters { get; }
        /// <summary> Policy assignment scope. </summary>
        public string PolicyAssignmentScope { get; }
        /// <summary> Policy definition name. </summary>
        public string PolicyDefinitionName { get; }
        /// <summary> Policy definition action, i.e. effect. </summary>
        public string PolicyDefinitionAction { get; }
        /// <summary> Policy definition category. </summary>
        public string PolicyDefinitionCategory { get; }
        /// <summary> Policy set definition ID, if the policy assignment is for a policy set. </summary>
        public ResourceIdentifier PolicySetDefinitionId { get; }
        /// <summary> Policy set definition name, if the policy assignment is for a policy set. </summary>
        public string PolicySetDefinitionName { get; }
        /// <summary> Policy set definition owner, if the policy assignment is for a policy set. </summary>
        public string PolicySetDefinitionOwner { get; }
        /// <summary> Policy set definition category, if the policy assignment is for a policy set. </summary>
        public string PolicySetDefinitionCategory { get; }
        /// <summary> Policy set definition parameters, if the policy assignment is for a policy set. </summary>
        public string PolicySetDefinitionParameters { get; }
        /// <summary> Comma separated list of management group IDs, which represent the hierarchy of the management groups the resource is under. </summary>
        public string ManagementGroupIds { get; }
        /// <summary> Reference ID for the policy definition inside the policy set, if the policy assignment is for a policy set. </summary>
        public string PolicyDefinitionReferenceId { get; }
        /// <summary> Compliance state of the resource. </summary>
        public string ComplianceState { get; }
        /// <summary> Policy evaluation details. </summary>
        public PolicyEvaluationDetails PolicyEvaluationDetails { get; }
        /// <summary> Policy definition group names. </summary>
        public IReadOnlyList<string> PolicyDefinitionGroupNames { get; }
        /// <summary> Components state compliance records populated only when URL contains $expand=components clause. </summary>
        public IReadOnlyList<ComponentStateDetails> Components { get; }
        /// <summary> Evaluated policy definition version. </summary>
        public string PolicyDefinitionVersion { get; }
        /// <summary> Evaluated policy set definition version. </summary>
        public string PolicySetDefinitionVersion { get; }
        /// <summary> Evaluated policy assignment version. </summary>
        public string PolicyAssignmentVersion { get; }
        /// <summary> Additional Properties. </summary>
        public IReadOnlyDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
