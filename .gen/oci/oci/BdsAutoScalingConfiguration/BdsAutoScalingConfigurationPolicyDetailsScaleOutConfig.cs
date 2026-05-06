using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsAutoScalingConfiguration
{
    [JsiiByValue(fqn: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfig")]
    public class BdsAutoScalingConfigurationPolicyDetailsScaleOutConfig : oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#max_node_count BdsAutoScalingConfiguration#max_node_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxNodeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxNodeCount
        {
            get;
            set;
        }

        /// <summary>metric block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#metric BdsAutoScalingConfiguration#metric}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetric\"}", isOptional: true)]
        public oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetric? Metric
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
