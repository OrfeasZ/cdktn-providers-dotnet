using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsAutoScalingConfiguration
{
    [JsiiByValue(fqn: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfig")]
    public class BdsAutoScalingConfigurationPolicyDetailsScaleDownConfig : oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#memory_step_size BdsAutoScalingConfiguration#memory_step_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryStepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryStepSize
        {
            get;
            set;
        }

        /// <summary>metric block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#metric BdsAutoScalingConfiguration#metric}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetric\"}", isOptional: true)]
        public oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetric? Metric
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#min_memory_per_node BdsAutoScalingConfiguration#min_memory_per_node}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minMemoryPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinMemoryPerNode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#min_ocpus_per_node BdsAutoScalingConfiguration#min_ocpus_per_node}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minOcpusPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinOcpusPerNode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#ocpu_step_size BdsAutoScalingConfiguration#ocpu_step_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocpuStepSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? OcpuStepSize
        {
            get;
            set;
        }
    }
}
