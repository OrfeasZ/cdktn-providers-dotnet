using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceComputeTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetails")]
    public class DatascienceComputeTargetComputeConfigurationDetails : oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/datascience_compute_target#compute_type DatascienceComputeTarget#compute_type}.</summary>
        [JsiiProperty(name: "computeType", typeJson: "{\"primitive\":\"string\"}")]
        public string ComputeType
        {
            get;
            set;
        }

        /// <summary>instance_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/datascience_compute_target#instance_configuration DatascienceComputeTarget#instance_configuration}
        /// </remarks>
        [JsiiProperty(name: "instanceConfiguration", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration\"}")]
        public oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration InstanceConfiguration
        {
            get;
            set;
        }

        /// <summary>scaling_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/datascience_compute_target#scaling_policy DatascienceComputeTarget#scaling_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scalingPolicy", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicy\"}", isOptional: true)]
        public oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicy? ScalingPolicy
        {
            get;
            set;
        }
    }
}
