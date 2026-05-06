using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiByValue(fqn: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetails")]
    public class DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetails : oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#bandwidth_mbps DatascienceModelDeployment#bandwidth_mbps}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bandwidthMbps", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BandwidthMbps
        {
            get;
            set;
        }

        /// <summary>instance_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#instance_configuration DatascienceModelDeployment#instance_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instanceConfiguration", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsInstanceConfiguration\"}", isOptional: true)]
        public oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsInstanceConfiguration? InstanceConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#maximum_bandwidth_mbps DatascienceModelDeployment#maximum_bandwidth_mbps}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumBandwidthMbps", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumBandwidthMbps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#model_id DatascienceModelDeployment#model_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelId
        {
            get;
            set;
        }

        /// <summary>scaling_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#scaling_policy DatascienceModelDeployment#scaling_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scalingPolicy", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicy\"}", isOptional: true)]
        public oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicy? ScalingPolicy
        {
            get;
            set;
        }
    }
}
