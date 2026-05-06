using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsAutoScalingConfiguration
{
    [JsiiInterface(nativeType: typeof(IBdsAutoScalingConfigurationPolicyDetailsScheduleDetailsTimeAndHorizontalScalingConfig), fullyQualifiedName: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScheduleDetailsTimeAndHorizontalScalingConfig")]
    public interface IBdsAutoScalingConfigurationPolicyDetailsScheduleDetailsTimeAndHorizontalScalingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#target_node_count BdsAutoScalingConfiguration#target_node_count}.</summary>
        [JsiiProperty(name: "targetNodeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetNodeCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#time_recurrence BdsAutoScalingConfiguration#time_recurrence}.</summary>
        [JsiiProperty(name: "timeRecurrence", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeRecurrence
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsAutoScalingConfigurationPolicyDetailsScheduleDetailsTimeAndHorizontalScalingConfig), fullyQualifiedName: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScheduleDetailsTimeAndHorizontalScalingConfig")]
        internal sealed class _Proxy : DeputyBase, oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScheduleDetailsTimeAndHorizontalScalingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#target_node_count BdsAutoScalingConfiguration#target_node_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetNodeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetNodeCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_auto_scaling_configuration#time_recurrence BdsAutoScalingConfiguration#time_recurrence}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeRecurrence", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeRecurrence
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
