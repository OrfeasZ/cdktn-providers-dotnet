using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.AutoscalingInstanceGroup
{
    [JsiiInterface(nativeType: typeof(IAutoscalingInstanceGroupCapacity), fullyQualifiedName: "scaleway.autoscalingInstanceGroup.AutoscalingInstanceGroupCapacity")]
    public interface IAutoscalingInstanceGroupCapacity
    {
        /// <summary>Time (in seconds) after a scaling action during which requests to carry out a new scaling action will be denied.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_group#cooldown_delay AutoscalingInstanceGroup#cooldown_delay}
        /// </remarks>
        [JsiiProperty(name: "cooldownDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CooldownDelay
        {
            get
            {
                return null;
            }
        }

        /// <summary>The maximum count of Instances for the Instance group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_group#max_replicas AutoscalingInstanceGroup#max_replicas}
        /// </remarks>
        [JsiiProperty(name: "maxReplicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxReplicas
        {
            get
            {
                return null;
            }
        }

        /// <summary>The minimum count of Instances for the Instance group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_group#min_replicas AutoscalingInstanceGroup#min_replicas}
        /// </remarks>
        [JsiiProperty(name: "minReplicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinReplicas
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingInstanceGroupCapacity), fullyQualifiedName: "scaleway.autoscalingInstanceGroup.AutoscalingInstanceGroupCapacity")]
        internal sealed class _Proxy : DeputyBase, scaleway.AutoscalingInstanceGroup.IAutoscalingInstanceGroupCapacity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Time (in seconds) after a scaling action during which requests to carry out a new scaling action will be denied.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_group#cooldown_delay AutoscalingInstanceGroup#cooldown_delay}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cooldownDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CooldownDelay
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The maximum count of Instances for the Instance group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_group#max_replicas AutoscalingInstanceGroup#max_replicas}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxReplicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxReplicas
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The minimum count of Instances for the Instance group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_group#min_replicas AutoscalingInstanceGroup#min_replicas}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minReplicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinReplicas
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
