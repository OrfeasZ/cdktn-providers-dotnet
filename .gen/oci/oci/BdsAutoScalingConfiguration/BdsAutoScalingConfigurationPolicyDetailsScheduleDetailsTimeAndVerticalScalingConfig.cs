using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsAutoScalingConfiguration
{
    [JsiiByValue(fqn: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScheduleDetailsTimeAndVerticalScalingConfig")]
    public class BdsAutoScalingConfigurationPolicyDetailsScheduleDetailsTimeAndVerticalScalingConfig : oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScheduleDetailsTimeAndVerticalScalingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#target_memory_per_node BdsAutoScalingConfiguration#target_memory_per_node}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetMemoryPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetMemoryPerNode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#target_ocpus_per_node BdsAutoScalingConfiguration#target_ocpus_per_node}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetOcpusPerNode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetOcpusPerNode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#target_shape BdsAutoScalingConfiguration#target_shape}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetShape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetShape
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#time_recurrence BdsAutoScalingConfiguration#time_recurrence}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeRecurrence", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeRecurrence
        {
            get;
            set;
        }
    }
}
