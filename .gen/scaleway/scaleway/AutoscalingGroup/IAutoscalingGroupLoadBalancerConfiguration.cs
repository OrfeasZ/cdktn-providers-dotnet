using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.AutoscalingGroup
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupLoadBalancerConfiguration), fullyQualifiedName: "scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfiguration")]
    public interface IAutoscalingGroupLoadBalancerConfiguration
    {
        /// <summary>The list of load balancer backend configurations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#backends AutoscalingGroup#backends}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationBackends" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "backends", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfigurationBackends\"},\"kind\":\"array\"}}]}}")]
        object Backends
        {
            get;
        }

        /// <summary>The ID of the load balancer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#load_balancer_id AutoscalingGroup#load_balancer_id}
        /// </remarks>
        [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
        string LoadBalancerId
        {
            get;
        }

        /// <summary>The auto-healing configuration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#auto_healing AutoscalingGroup#auto_healing}
        /// </remarks>
        [JsiiProperty(name: "autoHealing", typeJson: "{\"fqn\":\"scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfigurationAutoHealing\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationAutoHealing? AutoHealing
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupLoadBalancerConfiguration), fullyQualifiedName: "scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfiguration")]
        internal sealed class _Proxy : DeputyBase, scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The list of load balancer backend configurations.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#backends AutoscalingGroup#backends}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationBackends" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "backends", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfigurationBackends\"},\"kind\":\"array\"}}]}}")]
            public object Backends
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The ID of the load balancer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#load_balancer_id AutoscalingGroup#load_balancer_id}
            /// </remarks>
            [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
            public string LoadBalancerId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The auto-healing configuration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#auto_healing AutoscalingGroup#auto_healing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoHealing", typeJson: "{\"fqn\":\"scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfigurationAutoHealing\"}", isOptional: true)]
            public scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationAutoHealing? AutoHealing
            {
                get => GetInstanceProperty<scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationAutoHealing?>();
            }
        }
    }
}
