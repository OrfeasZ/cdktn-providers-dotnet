using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WafWebAppFirewallPolicy
{
    [JsiiClass(nativeType: typeof(oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseAccessControlOutputReference), fullyQualifiedName: "oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseAccessControlOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WafWebAppFirewallPolicyResponseAccessControlOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WafWebAppFirewallPolicyResponseAccessControlOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WafWebAppFirewallPolicyResponseAccessControlOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafWebAppFirewallPolicyResponseAccessControlOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseAccessControlRules\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRules(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseAccessControlRules[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseAccessControlRules).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseAccessControlRules).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRules")]
        public virtual void ResetRules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "rules", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseAccessControlRulesList\"}")]
        public virtual oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseAccessControlRulesList Rules
        {
            get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseAccessControlRulesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rulesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseAccessControlRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RulesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseAccessControl\"}", isOptional: true)]
        public virtual oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseAccessControl? InternalValue
        {
            get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseAccessControl?>();
            set => SetInstanceProperty(value);
        }
    }
}
