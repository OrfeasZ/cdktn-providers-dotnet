using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.AutoscalingGroup
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupLoadBalancerConfigurationAutoHealing), fullyQualifiedName: "scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfigurationAutoHealing")]
    public interface IAutoscalingGroupLoadBalancerConfigurationAutoHealing
    {
        /// <summary>Whether auto-healing is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#enabled AutoscalingGroup#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The grace period for health checks.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#grace_period AutoscalingGroup#grace_period}
        /// </remarks>
        [JsiiProperty(name: "gracePeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GracePeriod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupLoadBalancerConfigurationAutoHealing), fullyQualifiedName: "scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfigurationAutoHealing")]
        internal sealed class _Proxy : DeputyBase, scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationAutoHealing
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether auto-healing is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#enabled AutoscalingGroup#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The grace period for health checks.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#grace_period AutoscalingGroup#grace_period}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gracePeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GracePeriod
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
