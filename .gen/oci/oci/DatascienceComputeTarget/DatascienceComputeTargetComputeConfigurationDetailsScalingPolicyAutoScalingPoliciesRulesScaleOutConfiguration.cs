using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceComputeTarget
{
    [JsiiByValue(fqn: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration")]
    public class DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration : oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesRulesScaleOutConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datascience_compute_target#instance_count_adjustment DatascienceComputeTarget#instance_count_adjustment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceCountAdjustment", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InstanceCountAdjustment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datascience_compute_target#pending_duration DatascienceComputeTarget#pending_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pendingDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PendingDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datascience_compute_target#query DatascienceComputeTarget#query}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Query
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datascience_compute_target#scaling_configuration_type DatascienceComputeTarget#scaling_configuration_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scalingConfigurationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScalingConfigurationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datascience_compute_target#threshold DatascienceComputeTarget#threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Threshold
        {
            get;
            set;
        }
    }
}
