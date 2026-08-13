using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiClass(nativeType: typeof(stripe.Invoice.InvoiceShippingCostShippingRateDataFixedAmountOutputReference), fullyQualifiedName: "stripe.invoice.InvoiceShippingCostShippingRateDataFixedAmountOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InvoiceShippingCostShippingRateDataFixedAmountOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public InvoiceShippingCostShippingRateDataFixedAmountOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected InvoiceShippingCostShippingRateDataFixedAmountOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InvoiceShippingCostShippingRateDataFixedAmountOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="stripe.Invoice.IInvoiceShippingCostShippingRateDataFixedAmountCurrencyOptions" />&gt;</param>
        [JsiiMethod(name: "putCurrencyOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateDataFixedAmountCurrencyOptions\"},\"kind\":\"map\"}}]}}}]")]
        public virtual void PutCurrencyOptions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case System.Collections.Generic.IDictionary<string, stripe.Invoice.IInvoiceShippingCostShippingRateDataFixedAmountCurrencyOptions> cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(stripe.Invoice.IInvoiceShippingCostShippingRateDataFixedAmountCurrencyOptions).FullName}>; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(stripe.Invoice.IInvoiceShippingCostShippingRateDataFixedAmountCurrencyOptions).FullName}>; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCurrencyOptions")]
        public virtual void ResetCurrencyOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "currencyOptions", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateDataFixedAmountCurrencyOptionsMap\"}")]
        public virtual stripe.Invoice.InvoiceShippingCostShippingRateDataFixedAmountCurrencyOptionsMap CurrencyOptions
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceShippingCostShippingRateDataFixedAmountCurrencyOptionsMap>()!;
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

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="stripe.Invoice.IInvoiceShippingCostShippingRateDataFixedAmountCurrencyOptions" />&gt;</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "currencyOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateDataFixedAmountCurrencyOptions\"},\"kind\":\"map\"}}]}}", isOptional: true)]
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

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoiceShippingCostShippingRateDataFixedAmount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateDataFixedAmount\"}]}}", isOptional: true)]
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
                        case stripe.Invoice.IInvoiceShippingCostShippingRateDataFixedAmount cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Invoice.IInvoiceShippingCostShippingRateDataFixedAmount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
