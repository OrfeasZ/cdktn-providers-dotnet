using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.AutoscalingGroup
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupScalingPolicy), fullyQualifiedName: "scaleway.autoscalingGroup.AutoscalingGroupScalingPolicy")]
    public interface IAutoscalingGroupScalingPolicy
    {
        /// <summary>The maximum number of instances in the group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#maximum_size AutoscalingGroup#maximum_size}
        /// </remarks>
        [JsiiProperty(name: "maximumSize", typeJson: "{\"primitive\":\"number\"}")]
        double MaximumSize
        {
            get;
        }

        /// <summary>The minimum number of instances in the group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#minimum_size AutoscalingGroup#minimum_size}
        /// </remarks>
        [JsiiProperty(name: "minimumSize", typeJson: "{\"primitive\":\"number\"}")]
        double MinimumSize
        {
            get;
        }

        /// <summary>The target CPU utilization percentage to trigger scaling events.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#cpu_target AutoscalingGroup#cpu_target}
        /// </remarks>
        [JsiiProperty(name: "cpuTarget", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CpuTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>The fixed number of instances for the group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#fixed_size AutoscalingGroup#fixed_size}
        /// </remarks>
        [JsiiProperty(name: "fixedSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FixedSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>The target memory utilization percentage to trigger scaling events.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#memory_target AutoscalingGroup#memory_target}
        /// </remarks>
        [JsiiProperty(name: "memoryTarget", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MemoryTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>The cooldown duration after a scale-in event.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#scale_in_cooldown AutoscalingGroup#scale_in_cooldown}
        /// </remarks>
        [JsiiProperty(name: "scaleInCooldown", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScaleInCooldown
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of instances to remove during scale-in event.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#scale_in_step AutoscalingGroup#scale_in_step}
        /// </remarks>
        [JsiiProperty(name: "scaleInStep", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScaleInStep
        {
            get
            {
                return null;
            }
        }

        /// <summary>The cooldown duration after a scale-out event.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#scale_out_cooldown AutoscalingGroup#scale_out_cooldown}
        /// </remarks>
        [JsiiProperty(name: "scaleOutCooldown", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScaleOutCooldown
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of instances to add during scale-out event.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#scale_out_step AutoscalingGroup#scale_out_step}
        /// </remarks>
        [JsiiProperty(name: "scaleOutStep", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScaleOutStep
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupScalingPolicy), fullyQualifiedName: "scaleway.autoscalingGroup.AutoscalingGroupScalingPolicy")]
        internal sealed class _Proxy : DeputyBase, scaleway.AutoscalingGroup.IAutoscalingGroupScalingPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The maximum number of instances in the group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#maximum_size AutoscalingGroup#maximum_size}
            /// </remarks>
            [JsiiProperty(name: "maximumSize", typeJson: "{\"primitive\":\"number\"}")]
            public double MaximumSize
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The minimum number of instances in the group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#minimum_size AutoscalingGroup#minimum_size}
            /// </remarks>
            [JsiiProperty(name: "minimumSize", typeJson: "{\"primitive\":\"number\"}")]
            public double MinimumSize
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The target CPU utilization percentage to trigger scaling events.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#cpu_target AutoscalingGroup#cpu_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cpuTarget", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CpuTarget
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The fixed number of instances for the group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#fixed_size AutoscalingGroup#fixed_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fixedSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FixedSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The target memory utilization percentage to trigger scaling events.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#memory_target AutoscalingGroup#memory_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memoryTarget", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MemoryTarget
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The cooldown duration after a scale-in event.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#scale_in_cooldown AutoscalingGroup#scale_in_cooldown}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scaleInCooldown", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScaleInCooldown
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of instances to remove during scale-in event.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#scale_in_step AutoscalingGroup#scale_in_step}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scaleInStep", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScaleInStep
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The cooldown duration after a scale-out event.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#scale_out_cooldown AutoscalingGroup#scale_out_cooldown}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scaleOutCooldown", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScaleOutCooldown
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of instances to add during scale-out event.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#scale_out_step AutoscalingGroup#scale_out_step}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scaleOutStep", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScaleOutStep
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
