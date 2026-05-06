using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsAutoScalingConfiguration
{
    [JsiiInterface(nativeType: typeof(IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfig), fullyQualifiedName: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfig")]
    public interface IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfig
    {
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
        [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetric\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetric? Metric
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#min_memory_per_node BdsAutoScalingConfiguration#min_memory_per_node}.</summary>
        [JsiiProperty(name: "minMemoryPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinMemoryPerNode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#min_ocpus_per_node BdsAutoScalingConfiguration#min_ocpus_per_node}.</summary>
        [JsiiProperty(name: "minOcpusPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinOcpusPerNode
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

        [JsiiTypeProxy(nativeType: typeof(IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfig), fullyQualifiedName: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfig")]
        internal sealed class _Proxy : DeputyBase, oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
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
            [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetric\"}", isOptional: true)]
            public oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetric? Metric
            {
                get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetric?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#min_memory_per_node BdsAutoScalingConfiguration#min_memory_per_node}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minMemoryPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinMemoryPerNode
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#min_ocpus_per_node BdsAutoScalingConfiguration#min_ocpus_per_node}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minOcpusPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinOcpusPerNode
            {
                get => GetInstanceProperty<double?>();
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
