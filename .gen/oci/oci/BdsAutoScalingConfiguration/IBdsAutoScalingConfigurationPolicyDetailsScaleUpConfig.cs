using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsAutoScalingConfiguration
{
    [JsiiInterface(nativeType: typeof(IBdsAutoScalingConfigurationPolicyDetailsScaleUpConfig), fullyQualifiedName: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleUpConfig")]
    public interface IBdsAutoScalingConfigurationPolicyDetailsScaleUpConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#max_memory_per_node BdsAutoScalingConfiguration#max_memory_per_node}.</summary>
        [JsiiProperty(name: "maxMemoryPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxMemoryPerNode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#max_ocpus_per_node BdsAutoScalingConfiguration#max_ocpus_per_node}.</summary>
        [JsiiProperty(name: "maxOcpusPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxOcpusPerNode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#memory_step_size BdsAutoScalingConfiguration#memory_step_size}.</summary>
        [JsiiProperty(name: "memoryStepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MemoryStepSize
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
        [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleUpConfigMetric\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleUpConfigMetric? Metric
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#ocpu_step_size BdsAutoScalingConfiguration#ocpu_step_size}.</summary>
        [JsiiProperty(name: "ocpuStepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OcpuStepSize
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsAutoScalingConfigurationPolicyDetailsScaleUpConfig), fullyQualifiedName: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleUpConfig")]
        internal sealed class _Proxy : DeputyBase, oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleUpConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#max_memory_per_node BdsAutoScalingConfiguration#max_memory_per_node}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxMemoryPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxMemoryPerNode
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#max_ocpus_per_node BdsAutoScalingConfiguration#max_ocpus_per_node}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxOcpusPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxOcpusPerNode
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#memory_step_size BdsAutoScalingConfiguration#memory_step_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memoryStepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MemoryStepSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>metric block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#metric BdsAutoScalingConfiguration#metric}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleUpConfigMetric\"}", isOptional: true)]
            public oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleUpConfigMetric? Metric
            {
                get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleUpConfigMetric?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#ocpu_step_size BdsAutoScalingConfiguration#ocpu_step_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocpuStepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OcpuStepSize
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
