using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsAutoScalingConfiguration
{
    [JsiiInterface(nativeType: typeof(IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfig), fullyQualifiedName: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfig")]
    public interface IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#max_node_count BdsAutoScalingConfiguration#max_node_count}.</summary>
        [JsiiProperty(name: "maxNodeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxNodeCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>metric block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#metric BdsAutoScalingConfiguration#metric}
        /// </remarks>
        [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetric\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetric? Metric
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#step_size BdsAutoScalingConfiguration#step_size}.</summary>
        [JsiiProperty(name: "stepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StepSize
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfig), fullyQualifiedName: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfig")]
        internal sealed class _Proxy : DeputyBase, oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#max_node_count BdsAutoScalingConfiguration#max_node_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxNodeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxNodeCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>metric block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#metric BdsAutoScalingConfiguration#metric}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetric\"}", isOptional: true)]
            public oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetric? Metric
            {
                get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetric?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#step_size BdsAutoScalingConfiguration#step_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StepSize
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
