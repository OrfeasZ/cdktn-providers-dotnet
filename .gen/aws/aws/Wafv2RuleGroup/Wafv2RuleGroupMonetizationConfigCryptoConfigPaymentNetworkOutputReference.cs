using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2RuleGroup
{
    [JsiiClass(nativeType: typeof(aws.Wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkOutputReference), fullyQualifiedName: "aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPrices", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices\"}}]")]
        public virtual void PutPrices(aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices)}, new object[]{@value});
        }

        [JsiiProperty(name: "prices", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPricesOutputReference\"}")]
        public virtual aws.Wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPricesOutputReference Prices
        {
            get => GetInstanceProperty<aws.Wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPricesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "chainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ChainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pricesInput", typeJson: "{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices\"}", isOptional: true)]
        public virtual aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices? PricesInput
        {
            get => GetInstanceProperty<aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetworkPrices?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "walletAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WalletAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "chain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Chain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "walletAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WalletAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.wafv2RuleGroup.Wafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork\"}]}}", isOptional: true)]
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
                        case aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Wafv2RuleGroup.IWafv2RuleGroupMonetizationConfigCryptoConfigPaymentNetwork).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
