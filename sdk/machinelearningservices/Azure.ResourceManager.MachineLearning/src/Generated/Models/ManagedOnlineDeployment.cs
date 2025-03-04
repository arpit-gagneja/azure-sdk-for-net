// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Properties specific to a ManagedOnlineDeployment. </summary>
    public partial class ManagedOnlineDeployment : OnlineDeploymentProperties
    {
        /// <summary> Initializes a new instance of ManagedOnlineDeployment. </summary>
        public ManagedOnlineDeployment()
        {
            EndpointComputeType = EndpointComputeType.Managed;
        }

        /// <summary> Initializes a new instance of ManagedOnlineDeployment. </summary>
        /// <param name="codeConfiguration"> Code configuration for the endpoint deployment. </param>
        /// <param name="description"> Description of the endpoint deployment. </param>
        /// <param name="environmentId"> ARM resource ID of the environment specification for the endpoint deployment. </param>
        /// <param name="environmentVariables"> Environment variables configuration for the deployment. </param>
        /// <param name="properties"> Property dictionary. Properties can be added, but not removed or altered. </param>
        /// <param name="appInsightsEnabled"> If true, enables Application Insights logging. </param>
        /// <param name="egressPublicNetworkAccess"> If Enabled, allow egress public network access. If Disabled, this will create secure egress. Default: Enabled. </param>
        /// <param name="endpointComputeType"> [Required] The compute type of the endpoint. </param>
        /// <param name="instanceType"> Compute instance type. </param>
        /// <param name="livenessProbe"> Liveness probe monitors the health of the container regularly. </param>
        /// <param name="model"> The URI path to the model. </param>
        /// <param name="modelMountPath"> The path to mount the model in custom container. </param>
        /// <param name="privateNetworkConnection">
        /// If true, enable private network connection.
        /// DEPRECATED for future API versions. Use EgressPublicNetworkAccess.
        /// </param>
        /// <param name="provisioningState"> Provisioning state for the endpoint deployment. </param>
        /// <param name="readinessProbe"> Readiness probe validates if the container is ready to serve traffic. The properties and defaults are the same as liveness probe. </param>
        /// <param name="requestSettings"> Request settings for the deployment. </param>
        /// <param name="scaleSettings">
        /// Scale settings for the deployment.
        /// If it is null or not provided,
        /// it defaults to TargetUtilizationScaleSettings for KubernetesOnlineDeployment
        /// and to DefaultScaleSettings for ManagedOnlineDeployment.
        /// Please note <see cref="OnlineScaleSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DefaultScaleSettings"/> and <see cref="TargetUtilizationScaleSettings"/>.
        /// </param>
        internal ManagedOnlineDeployment(CodeConfiguration codeConfiguration, string description, string environmentId, IDictionary<string, string> environmentVariables, IDictionary<string, string> properties, bool? appInsightsEnabled, EgressPublicNetworkAccessType? egressPublicNetworkAccess, EndpointComputeType endpointComputeType, string instanceType, ProbeSettings livenessProbe, string model, string modelMountPath, bool? privateNetworkConnection, DeploymentProvisioningState? provisioningState, ProbeSettings readinessProbe, OnlineRequestSettings requestSettings, OnlineScaleSettings scaleSettings) : base(codeConfiguration, description, environmentId, environmentVariables, properties, appInsightsEnabled, egressPublicNetworkAccess, endpointComputeType, instanceType, livenessProbe, model, modelMountPath, privateNetworkConnection, provisioningState, readinessProbe, requestSettings, scaleSettings)
        {
            EndpointComputeType = endpointComputeType;
        }
    }
}
