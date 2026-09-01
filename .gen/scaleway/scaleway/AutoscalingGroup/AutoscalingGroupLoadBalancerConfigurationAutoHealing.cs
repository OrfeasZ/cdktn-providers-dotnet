using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.AutoscalingGroup
{
    [JsiiByValue(fqn: "scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfigurationAutoHealing")]
    public class AutoscalingGroupLoadBalancerConfigurationAutoHealing : scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationAutoHealing
    {
        private object? _enabled;

        /// <summary>Whether auto-healing is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#enabled AutoscalingGroup#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>The grace period for health checks.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#grace_period AutoscalingGroup#grace_period}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gracePeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GracePeriod
        {
            get;
            set;
        }
    }
}
