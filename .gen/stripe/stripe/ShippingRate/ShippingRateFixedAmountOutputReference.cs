using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ShippingRate
{
    [JsiiClass(nativeType: typeof(stripe.ShippingRate.ShippingRateFixedAmountOutputReference), fullyQualifiedName: "stripe.shippingRate.ShippingRateFixedAmountOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ShippingRateFixedAmountOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ShippingRateFixedAmountOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ShippingRateFixedAmountOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ShippingRateFixedAmountOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCurrencyOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.shippingRate.ShippingRateFixedAmountCurrencyOptions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCurrencyOptions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.ShippingRate.IShippingRateFixedAmountCurrencyOptions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.ShippingRate.IShippingRateFixedAmountCurrencyOptions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.ShippingRate.IShippingRateFixedAmountCurrencyOptions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCurrencyOptions")]
        public virtual void ResetCurrencyOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "currencyOptions", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateFixedAmountCurrencyOptionsList\"}")]
        public virtual stripe.ShippingRate.ShippingRateFixedAmountCurrencyOptionsList CurrencyOptions
        {
            get => GetInstanceProperty<stripe.ShippingRate.ShippingRateFixedAmountCurrencyOptionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AmountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "currencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CurrencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "currencyOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.shippingRate.ShippingRateFixedAmountCurrencyOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CurrencyOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Amount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Currency
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateFixedAmount\"}", isOptional: true)]
        public virtual stripe.ShippingRate.IShippingRateFixedAmount? InternalValue
        {
            get => GetInstanceProperty<stripe.ShippingRate.IShippingRateFixedAmount?>();
            set => SetInstanceProperty(value);
        }
    }
}
