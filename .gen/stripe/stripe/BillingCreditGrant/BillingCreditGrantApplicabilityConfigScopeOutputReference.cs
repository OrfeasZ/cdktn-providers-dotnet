using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingCreditGrant
{
    [JsiiClass(nativeType: typeof(stripe.BillingCreditGrant.BillingCreditGrantApplicabilityConfigScopeOutputReference), fullyQualifiedName: "stripe.billingCreditGrant.BillingCreditGrantApplicabilityConfigScopeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BillingCreditGrantApplicabilityConfigScopeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BillingCreditGrantApplicabilityConfigScopeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BillingCreditGrantApplicabilityConfigScopeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BillingCreditGrantApplicabilityConfigScopeOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfigScopePrices" />)[]</param>
        [JsiiMethod(name: "putPrices", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.billingCreditGrant.BillingCreditGrantApplicabilityConfigScopePrices\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPrices(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfigScopePrices[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfigScopePrices).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfigScopePrices).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPrices")]
        public virtual void ResetPrices()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPriceType")]
        public virtual void ResetPriceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "prices", typeJson: "{\"fqn\":\"stripe.billingCreditGrant.BillingCreditGrantApplicabilityConfigScopePricesList\"}")]
        public virtual stripe.BillingCreditGrant.BillingCreditGrantApplicabilityConfigScopePricesList Prices
        {
            get => GetInstanceProperty<stripe.BillingCreditGrant.BillingCreditGrantApplicabilityConfigScopePricesList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfigScopePrices" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pricesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.billingCreditGrant.BillingCreditGrantApplicabilityConfigScopePrices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PricesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PriceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "priceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PriceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfigScope" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.billingCreditGrant.BillingCreditGrantApplicabilityConfigScope\"}]}}", isOptional: true)]
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
                        case stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfigScope cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfigScope).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
