using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.AutoscalingGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfiguration")]
    public class AutoscalingGroupLoadBalancerConfiguration : scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfiguration
    {
        private object _backends;

        /// <summary>The list of load balancer backend configurations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#backends AutoscalingGroup#backends}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationBackends" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "backends", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfigurationBackends\"},\"kind\":\"array\"}}]}}")]
        public object Backends
        {
            get => _backends;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationBackends[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationBackends).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationBackends).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _backends = value;
            }
        }

        /// <summary>The ID of the load balancer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#load_balancer_id AutoscalingGroup#load_balancer_id}
        /// </remarks>
        [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
        public string LoadBalancerId
        {
            get;
            set;
        }

        /// <summary>The auto-healing configuration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#auto_healing AutoscalingGroup#auto_healing}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoHealing", typeJson: "{\"fqn\":\"scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfigurationAutoHealing\"}", isOptional: true)]
        public scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationAutoHealing? AutoHealing
        {
            get;
            set;
        }
    }
}
