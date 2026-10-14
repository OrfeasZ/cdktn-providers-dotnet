using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    [JsiiClass(nativeType: typeof(aws.Wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigOutputReference), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2RuleGroupMonetizationConfigCryptoConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2RuleGroupMonetizationConfigCryptoConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected Wafv2RuleGroupMonetizationConfigCryptoConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2RuleGroupMonetizationConfigCryptoConfigOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork" />)[]</param>
        [JsiiMethod(name: "putPaymentNetwork", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPaymentNetwork(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "paymentNetwork", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkList\"}")]
        public virtual aws.Wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkList PaymentNetwork
        {
            get => GetInstanceProperty<aws.Wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentNetworkInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PaymentNetworkInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfig\"}", isOptional: true)]
        public virtual aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
