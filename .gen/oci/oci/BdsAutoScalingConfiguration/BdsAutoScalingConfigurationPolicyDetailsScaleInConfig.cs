using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsAutoScalingConfiguration
{
    [JsiiByValue(fqn: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleInConfig")]
    public class BdsAutoScalingConfigurationPolicyDetailsScaleInConfig : oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleInConfig
    {
        /// <summary>metric block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#metric BdsAutoScalingConfiguration#metric}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleInConfigMetric\"}", isOptional: true)]
        public oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleInConfigMetric? Metric
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#min_node_count BdsAutoScalingConfiguration#min_node_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minNodeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinNodeCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#step_size BdsAutoScalingConfiguration#step_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StepSize
        {
            get;
            set;
        }
    }
}
