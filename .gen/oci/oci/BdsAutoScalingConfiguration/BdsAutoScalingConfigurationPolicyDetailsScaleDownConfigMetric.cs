using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsAutoScalingConfiguration
{
    [JsiiByValue(fqn: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetric")]
    public class BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetric : oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetric
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#metric_type BdsAutoScalingConfiguration#metric_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricType
        {
            get;
            set;
        }

        /// <summary>threshold block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#threshold BdsAutoScalingConfiguration#threshold}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "threshold", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetricThreshold\"}", isOptional: true)]
        public oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetricThreshold? Threshold
        {
            get;
            set;
        }
    }
}
