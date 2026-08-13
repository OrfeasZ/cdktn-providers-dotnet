using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiClass(nativeType: typeof(stripe.Invoice.InvoiceShippingCostOutputReference), fullyQualifiedName: "stripe.invoice.InvoiceShippingCostOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InvoiceShippingCostOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public InvoiceShippingCostOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected InvoiceShippingCostOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InvoiceShippingCostOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putShippingRateData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateData\"}}]")]
        public virtual void PutShippingRateData(stripe.Invoice.IInvoiceShippingCostShippingRateData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoiceShippingCostShippingRateData)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetShippingRate")]
        public virtual void ResetShippingRate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShippingRateData")]
        public virtual void ResetShippingRateData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "amountSubtotal", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountSubtotal
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "amountTax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountTax
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "amountTotal", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountTotal
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "shippingRateData", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateDataOutputReference\"}")]
        public virtual stripe.Invoice.InvoiceShippingCostShippingRateDataOutputReference ShippingRateData
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceShippingCostShippingRateDataOutputReference>()!;
        }

        [JsiiProperty(name: "taxes", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingCostTaxesList\"}")]
        public virtual stripe.Invoice.InvoiceShippingCostTaxesList Taxes
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceShippingCostTaxesList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoiceShippingCostShippingRateData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shippingRateDataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateData\"}]}}", isOptional: true)]
        public virtual object? ShippingRateDataInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shippingRateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShippingRateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "shippingRate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShippingRate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoiceShippingCost" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoiceShippingCost\"}]}}", isOptional: true)]
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
                        case stripe.Invoice.IInvoiceShippingCost cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Invoice.IInvoiceShippingCost).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
