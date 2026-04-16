using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PromotionCode
{
    [JsiiClass(nativeType: typeof(stripe.PromotionCode.PromotionCodeRestrictionsOutputReference), fullyQualifiedName: "stripe.promotionCode.PromotionCodeRestrictionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PromotionCodeRestrictionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PromotionCodeRestrictionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PromotionCodeRestrictionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PromotionCodeRestrictionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCurrencyOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.promotionCode.PromotionCodeRestrictionsCurrencyOptions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCurrencyOptions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.PromotionCode.IPromotionCodeRestrictionsCurrencyOptions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PromotionCode.IPromotionCodeRestrictionsCurrencyOptions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PromotionCode.IPromotionCodeRestrictionsCurrencyOptions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCurrencyOptions")]
        public virtual void ResetCurrencyOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirstTimeTransaction")]
        public virtual void ResetFirstTimeTransaction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinimumAmount")]
        public virtual void ResetMinimumAmount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinimumAmountCurrency")]
        public virtual void ResetMinimumAmountCurrency()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "currencyOptions", typeJson: "{\"fqn\":\"stripe.promotionCode.PromotionCodeRestrictionsCurrencyOptionsList\"}")]
        public virtual stripe.PromotionCode.PromotionCodeRestrictionsCurrencyOptionsList CurrencyOptions
        {
            get => GetInstanceProperty<stripe.PromotionCode.PromotionCodeRestrictionsCurrencyOptionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "currencyOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.promotionCode.PromotionCodeRestrictionsCurrencyOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CurrencyOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firstTimeTransactionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? FirstTimeTransactionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumAmountCurrencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MinimumAmountCurrencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumAmountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinimumAmountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "firstTimeTransaction", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object FirstTimeTransaction
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

        [JsiiProperty(name: "minimumAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinimumAmount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minimumAmountCurrency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MinimumAmountCurrency
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.promotionCode.PromotionCodeRestrictions\"}", isOptional: true)]
        public virtual stripe.PromotionCode.IPromotionCodeRestrictions? InternalValue
        {
            get => GetInstanceProperty<stripe.PromotionCode.IPromotionCodeRestrictions?>();
            set => SetInstanceProperty(value);
        }
    }
}
