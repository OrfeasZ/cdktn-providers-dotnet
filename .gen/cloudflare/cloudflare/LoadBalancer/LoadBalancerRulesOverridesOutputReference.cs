using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancer
{
    [JsiiClass(nativeType: typeof(cloudflare.LoadBalancer.LoadBalancerRulesOverridesOutputReference), fullyQualifiedName: "cloudflare.loadBalancer.LoadBalancerRulesOverridesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LoadBalancerRulesOverridesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LoadBalancerRulesOverridesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LoadBalancerRulesOverridesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadBalancerRulesOverridesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdaptiveRouting", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerRulesOverridesAdaptiveRouting\"}}]")]
        public virtual void PutAdaptiveRouting(cloudflare.LoadBalancer.ILoadBalancerRulesOverridesAdaptiveRouting @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.LoadBalancer.ILoadBalancerRulesOverridesAdaptiveRouting)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLocationStrategy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerRulesOverridesLocationStrategy\"}}]")]
        public virtual void PutLocationStrategy(cloudflare.LoadBalancer.ILoadBalancerRulesOverridesLocationStrategy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.LoadBalancer.ILoadBalancerRulesOverridesLocationStrategy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRandomSteering", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerRulesOverridesRandomSteering\"}}]")]
        public virtual void PutRandomSteering(cloudflare.LoadBalancer.ILoadBalancerRulesOverridesRandomSteering @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.LoadBalancer.ILoadBalancerRulesOverridesRandomSteering)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSessionAffinityAttributes", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerRulesOverridesSessionAffinityAttributes\"}}]")]
        public virtual void PutSessionAffinityAttributes(cloudflare.LoadBalancer.ILoadBalancerRulesOverridesSessionAffinityAttributes @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.LoadBalancer.ILoadBalancerRulesOverridesSessionAffinityAttributes)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdaptiveRouting")]
        public virtual void ResetAdaptiveRouting()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCountryPools")]
        public virtual void ResetCountryPools()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultPools")]
        public virtual void ResetDefaultPools()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFallbackPool")]
        public virtual void ResetFallbackPool()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocationStrategy")]
        public virtual void ResetLocationStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPopPools")]
        public virtual void ResetPopPools()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRandomSteering")]
        public virtual void ResetRandomSteering()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegionPools")]
        public virtual void ResetRegionPools()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSessionAffinity")]
        public virtual void ResetSessionAffinity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSessionAffinityAttributes")]
        public virtual void ResetSessionAffinityAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSessionAffinityTtl")]
        public virtual void ResetSessionAffinityTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSteeringPolicy")]
        public virtual void ResetSteeringPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTtl")]
        public virtual void ResetTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "adaptiveRouting", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerRulesOverridesAdaptiveRoutingOutputReference\"}")]
        public virtual cloudflare.LoadBalancer.LoadBalancerRulesOverridesAdaptiveRoutingOutputReference AdaptiveRouting
        {
            get => GetInstanceProperty<cloudflare.LoadBalancer.LoadBalancerRulesOverridesAdaptiveRoutingOutputReference>()!;
        }

        [JsiiProperty(name: "locationStrategy", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerRulesOverridesLocationStrategyOutputReference\"}")]
        public virtual cloudflare.LoadBalancer.LoadBalancerRulesOverridesLocationStrategyOutputReference LocationStrategy
        {
            get => GetInstanceProperty<cloudflare.LoadBalancer.LoadBalancerRulesOverridesLocationStrategyOutputReference>()!;
        }

        [JsiiProperty(name: "randomSteering", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerRulesOverridesRandomSteeringOutputReference\"}")]
        public virtual cloudflare.LoadBalancer.LoadBalancerRulesOverridesRandomSteeringOutputReference RandomSteering
        {
            get => GetInstanceProperty<cloudflare.LoadBalancer.LoadBalancerRulesOverridesRandomSteeringOutputReference>()!;
        }

        [JsiiProperty(name: "sessionAffinityAttributes", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerRulesOverridesSessionAffinityAttributesOutputReference\"}")]
        public virtual cloudflare.LoadBalancer.LoadBalancerRulesOverridesSessionAffinityAttributesOutputReference SessionAffinityAttributes
        {
            get => GetInstanceProperty<cloudflare.LoadBalancer.LoadBalancerRulesOverridesSessionAffinityAttributesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adaptiveRoutingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerRulesOverridesAdaptiveRouting\"}]}}", isOptional: true)]
        public virtual object? AdaptiveRoutingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "countryPoolsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? CountryPoolsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultPoolsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DefaultPoolsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fallbackPoolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FallbackPoolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationStrategyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerRulesOverridesLocationStrategy\"}]}}", isOptional: true)]
        public virtual object? LocationStrategyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "popPoolsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? PopPoolsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "randomSteeringInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerRulesOverridesRandomSteering\"}]}}", isOptional: true)]
        public virtual object? RandomSteeringInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionPoolsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? RegionPoolsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sessionAffinityAttributesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerRulesOverridesSessionAffinityAttributes\"}]}}", isOptional: true)]
        public virtual object? SessionAffinityAttributesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sessionAffinityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SessionAffinityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sessionAffinityTtlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SessionAffinityTtlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "steeringPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SteeringPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ttlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TtlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "countryPools", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}")]
        public virtual object CountryPools
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, string[]> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, string[]>; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, string[]>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "defaultPools", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DefaultPools
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fallbackPool", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FallbackPool
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "popPools", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}")]
        public virtual object PopPools
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, string[]> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, string[]>; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, string[]>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "regionPools", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}")]
        public virtual object RegionPools
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, string[]> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, string[]>; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, string[]>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "sessionAffinity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SessionAffinity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sessionAffinityTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SessionAffinityTtl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "steeringPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SteeringPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ttl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerRulesOverrides\"}]}}", isOptional: true)]
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
                        case cloudflare.LoadBalancer.ILoadBalancerRulesOverrides cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.LoadBalancer.ILoadBalancerRulesOverrides).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
