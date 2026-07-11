using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorFirewallPolicy
{
    [JsiiClass(nativeType: typeof(azurerm.CdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyLogScrubbingOutputReference), fullyQualifiedName: "azurerm.cdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyLogScrubbingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CdnFrontdoorFirewallPolicyLogScrubbingOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CdnFrontdoorFirewallPolicyLogScrubbingOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CdnFrontdoorFirewallPolicyLogScrubbingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnFrontdoorFirewallPolicyLogScrubbingOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorFirewallPolicy.ICdnFrontdoorFirewallPolicyLogScrubbingScrubbingRule" />)[]</param>
        [JsiiMethod(name: "putScrubbingRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyLogScrubbingScrubbingRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutScrubbingRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorFirewallPolicy.ICdnFrontdoorFirewallPolicyLogScrubbingScrubbingRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorFirewallPolicy.ICdnFrontdoorFirewallPolicyLogScrubbingScrubbingRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorFirewallPolicy.ICdnFrontdoorFirewallPolicyLogScrubbingScrubbingRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "scrubbingRule", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyLogScrubbingScrubbingRuleList\"}")]
        public virtual azurerm.CdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyLogScrubbingScrubbingRuleList ScrubbingRule
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyLogScrubbingScrubbingRuleList>()!;
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorFirewallPolicy.ICdnFrontdoorFirewallPolicyLogScrubbingScrubbingRule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scrubbingRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyLogScrubbingScrubbingRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ScrubbingRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorFirewallPolicy.CdnFrontdoorFirewallPolicyLogScrubbing\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorFirewallPolicy.ICdnFrontdoorFirewallPolicyLogScrubbing? InternalValue
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorFirewallPolicy.ICdnFrontdoorFirewallPolicyLogScrubbing?>();
            set => SetInstanceProperty(value);
        }
    }
}
