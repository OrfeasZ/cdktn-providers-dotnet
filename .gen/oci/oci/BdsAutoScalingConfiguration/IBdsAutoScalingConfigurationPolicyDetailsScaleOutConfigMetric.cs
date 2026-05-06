using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsAutoScalingConfiguration
{
    [JsiiInterface(nativeType: typeof(IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetric), fullyQualifiedName: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetric")]
    public interface IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetric
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#metric_type BdsAutoScalingConfiguration#metric_type}.</summary>
        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricType
        {
            get
            {
                return null;
            }
        }

        /// <summary>threshold block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#threshold BdsAutoScalingConfiguration#threshold}
        /// </remarks>
        [JsiiProperty(name: "threshold", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetricThreshold\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetricThreshold? Threshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetric), fullyQualifiedName: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetric")]
        internal sealed class _Proxy : DeputyBase, oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetric
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#metric_type BdsAutoScalingConfiguration#metric_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>threshold block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#threshold BdsAutoScalingConfiguration#threshold}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "threshold", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetricThreshold\"}", isOptional: true)]
            public oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetricThreshold? Threshold
            {
                get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetricThreshold?>();
            }
        }
    }
}
