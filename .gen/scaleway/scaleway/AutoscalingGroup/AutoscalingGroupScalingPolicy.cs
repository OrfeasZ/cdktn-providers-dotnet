using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.AutoscalingGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.autoscalingGroup.AutoscalingGroupScalingPolicy")]
    public class AutoscalingGroupScalingPolicy : scaleway.AutoscalingGroup.IAutoscalingGroupScalingPolicy
    {
        /// <summary>The maximum number of instances in the group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#maximum_size AutoscalingGroup#maximum_size}
        /// </remarks>
        [JsiiProperty(name: "maximumSize", typeJson: "{\"primitive\":\"number\"}")]
        public double MaximumSize
        {
            get;
            set;
        }

        /// <summary>The minimum number of instances in the group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#minimum_size AutoscalingGroup#minimum_size}
        /// </remarks>
        [JsiiProperty(name: "minimumSize", typeJson: "{\"primitive\":\"number\"}")]
        public double MinimumSize
        {
            get;
            set;
        }

        /// <summary>The target CPU utilization percentage to trigger scaling events.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#cpu_target AutoscalingGroup#cpu_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cpuTarget", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CpuTarget
        {
            get;
            set;
        }

        /// <summary>The fixed number of instances for the group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#fixed_size AutoscalingGroup#fixed_size}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fixedSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FixedSize
        {
            get;
            set;
        }

        /// <summary>The target memory utilization percentage to trigger scaling events.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#memory_target AutoscalingGroup#memory_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memoryTarget", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryTarget
        {
            get;
            set;
        }

        /// <summary>The cooldown duration after a scale-in event.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#scale_in_cooldown AutoscalingGroup#scale_in_cooldown}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scaleInCooldown", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScaleInCooldown
        {
            get;
            set;
        }

        /// <summary>The number of instances to remove during scale-in event.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#scale_in_step AutoscalingGroup#scale_in_step}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scaleInStep", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ScaleInStep
        {
            get;
            set;
        }

        /// <summary>The cooldown duration after a scale-out event.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#scale_out_cooldown AutoscalingGroup#scale_out_cooldown}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scaleOutCooldown", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScaleOutCooldown
        {
            get;
            set;
        }

        /// <summary>The number of instances to add during scale-out event.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#scale_out_step AutoscalingGroup#scale_out_step}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scaleOutStep", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ScaleOutStep
        {
            get;
            set;
        }
    }
}
