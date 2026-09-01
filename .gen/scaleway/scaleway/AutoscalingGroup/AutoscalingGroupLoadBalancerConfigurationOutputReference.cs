using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.AutoscalingGroup
{
    [JsiiClass(nativeType: typeof(scaleway.AutoscalingGroup.AutoscalingGroupLoadBalancerConfigurationOutputReference), fullyQualifiedName: "scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutoscalingGroupLoadBalancerConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutoscalingGroupLoadBalancerConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroupLoadBalancerConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroupLoadBalancerConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAutoHealing", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfigurationAutoHealing\"}}]")]
        public virtual void PutAutoHealing(scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationAutoHealing @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationAutoHealing)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationBackends" />)[]</param>
        [JsiiMethod(name: "putBackends", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfigurationBackends\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutBackends(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationBackends[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationBackends).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationBackends).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoHealing")]
        public virtual void ResetAutoHealing()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "autoHealing", typeJson: "{\"fqn\":\"scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfigurationAutoHealingOutputReference\"}")]
        public virtual scaleway.AutoscalingGroup.AutoscalingGroupLoadBalancerConfigurationAutoHealingOutputReference AutoHealing
        {
            get => GetInstanceProperty<scaleway.AutoscalingGroup.AutoscalingGroupLoadBalancerConfigurationAutoHealingOutputReference>()!;
        }

        [JsiiProperty(name: "backends", typeJson: "{\"fqn\":\"scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfigurationBackendsList\"}")]
        public virtual scaleway.AutoscalingGroup.AutoscalingGroupLoadBalancerConfigurationBackendsList Backends
        {
            get => GetInstanceProperty<scaleway.AutoscalingGroup.AutoscalingGroupLoadBalancerConfigurationBackendsList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationAutoHealing" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoHealingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfigurationAutoHealing\"}]}}", isOptional: true)]
        public virtual object? AutoHealingInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationBackends" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backendsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfigurationBackends\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? BackendsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoadBalancerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfiguration" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfiguration\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfiguration cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfiguration).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
