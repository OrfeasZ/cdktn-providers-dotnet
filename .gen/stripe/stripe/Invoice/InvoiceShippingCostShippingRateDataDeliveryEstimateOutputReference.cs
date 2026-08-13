using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiClass(nativeType: typeof(stripe.Invoice.InvoiceShippingCostShippingRateDataDeliveryEstimateOutputReference), fullyQualifiedName: "stripe.invoice.InvoiceShippingCostShippingRateDataDeliveryEstimateOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InvoiceShippingCostShippingRateDataDeliveryEstimateOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public InvoiceShippingCostShippingRateDataDeliveryEstimateOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected InvoiceShippingCostShippingRateDataDeliveryEstimateOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InvoiceShippingCostShippingRateDataDeliveryEstimateOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMaximum", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateDataDeliveryEstimateMaximum\"}}]")]
        public virtual void PutMaximum(stripe.Invoice.IInvoiceShippingCostShippingRateDataDeliveryEstimateMaximum @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoiceShippingCostShippingRateDataDeliveryEstimateMaximum)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMinimum", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateDataDeliveryEstimateMinimum\"}}]")]
        public virtual void PutMinimum(stripe.Invoice.IInvoiceShippingCostShippingRateDataDeliveryEstimateMinimum @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Invoice.IInvoiceShippingCostShippingRateDataDeliveryEstimateMinimum)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMaximum")]
        public virtual void ResetMaximum()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinimum")]
        public virtual void ResetMinimum()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "maximum", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateDataDeliveryEstimateMaximumOutputReference\"}")]
        public virtual stripe.Invoice.InvoiceShippingCostShippingRateDataDeliveryEstimateMaximumOutputReference Maximum
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceShippingCostShippingRateDataDeliveryEstimateMaximumOutputReference>()!;
        }

        [JsiiProperty(name: "minimum", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateDataDeliveryEstimateMinimumOutputReference\"}")]
        public virtual stripe.Invoice.InvoiceShippingCostShippingRateDataDeliveryEstimateMinimumOutputReference Minimum
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceShippingCostShippingRateDataDeliveryEstimateMinimumOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoiceShippingCostShippingRateDataDeliveryEstimateMaximum" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maximumInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateDataDeliveryEstimateMaximum\"}]}}", isOptional: true)]
        public virtual object? MaximumInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoiceShippingCostShippingRateDataDeliveryEstimateMinimum" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minimumInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateDataDeliveryEstimateMinimum\"}]}}", isOptional: true)]
        public virtual object? MinimumInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Invoice.IInvoiceShippingCostShippingRateDataDeliveryEstimate" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateDataDeliveryEstimate\"}]}}", isOptional: true)]
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
                        case stripe.Invoice.IInvoiceShippingCostShippingRateDataDeliveryEstimate cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Invoice.IInvoiceShippingCostShippingRateDataDeliveryEstimate).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
