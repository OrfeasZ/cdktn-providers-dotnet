using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiInterface(nativeType: typeof(IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetails), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetails")]
    public interface IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#infrastructure_type DatascienceModelDeployment#infrastructure_type}.</summary>
        [JsiiProperty(name: "infrastructureType", typeJson: "{\"primitive\":\"string\"}")]
        string InfrastructureType
        {
            get;
        }

        /// <summary>instance_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#instance_configuration DatascienceModelDeployment#instance_configuration}
        /// </remarks>
        [JsiiProperty(name: "instanceConfiguration", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsInstanceConfiguration\"}")]
        oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsInstanceConfiguration InstanceConfiguration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#bandwidth_mbps DatascienceModelDeployment#bandwidth_mbps}.</summary>
        [JsiiProperty(name: "bandwidthMbps", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BandwidthMbps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#maximum_bandwidth_mbps DatascienceModelDeployment#maximum_bandwidth_mbps}.</summary>
        [JsiiProperty(name: "maximumBandwidthMbps", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumBandwidthMbps
        {
            get
            {
                return null;
            }
        }

        /// <summary>scaling_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#scaling_policy DatascienceModelDeployment#scaling_policy}
        /// </remarks>
        [JsiiProperty(name: "scalingPolicy", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicy? ScalingPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetails), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#infrastructure_type DatascienceModelDeployment#infrastructure_type}.</summary>
            [JsiiProperty(name: "infrastructureType", typeJson: "{\"primitive\":\"string\"}")]
            public string InfrastructureType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>instance_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#instance_configuration DatascienceModelDeployment#instance_configuration}
            /// </remarks>
            [JsiiProperty(name: "instanceConfiguration", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsInstanceConfiguration\"}")]
            public oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsInstanceConfiguration InstanceConfiguration
            {
                get => GetInstanceProperty<oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsInstanceConfiguration>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#bandwidth_mbps DatascienceModelDeployment#bandwidth_mbps}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bandwidthMbps", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BandwidthMbps
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#maximum_bandwidth_mbps DatascienceModelDeployment#maximum_bandwidth_mbps}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumBandwidthMbps", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumBandwidthMbps
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>scaling_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#scaling_policy DatascienceModelDeployment#scaling_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scalingPolicy", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicy\"}", isOptional: true)]
            public oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicy? ScalingPolicy
            {
                get => GetInstanceProperty<oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicy?>();
            }
        }
    }
}
