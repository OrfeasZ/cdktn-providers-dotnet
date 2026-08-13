using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.CreditNote
{
    [JsiiClass(nativeType: typeof(stripe.CreditNote.CreditNoteShippingCostOutputReference), fullyQualifiedName: "stripe.creditNote.CreditNoteShippingCostOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CreditNoteShippingCostOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CreditNoteShippingCostOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CreditNoteShippingCostOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CreditNoteShippingCostOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetShippingRate")]
        public virtual void ResetShippingRate()
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

        [JsiiProperty(name: "taxes", typeJson: "{\"fqn\":\"stripe.creditNote.CreditNoteShippingCostTaxesList\"}")]
        public virtual stripe.CreditNote.CreditNoteShippingCostTaxesList Taxes
        {
            get => GetInstanceProperty<stripe.CreditNote.CreditNoteShippingCostTaxesList>()!;
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.CreditNote.ICreditNoteShippingCost" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.creditNote.CreditNoteShippingCost\"}]}}", isOptional: true)]
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
                        case stripe.CreditNote.ICreditNoteShippingCost cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.CreditNote.ICreditNoteShippingCost).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
