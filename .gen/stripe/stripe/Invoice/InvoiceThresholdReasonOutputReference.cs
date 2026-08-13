using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiClass(nativeType: typeof(stripe.Invoice.InvoiceThresholdReasonOutputReference), fullyQualifiedName: "stripe.invoice.InvoiceThresholdReasonOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InvoiceThresholdReasonOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public InvoiceThresholdReasonOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected InvoiceThresholdReasonOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InvoiceThresholdReasonOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "amountGte", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountGte
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "itemReasons", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceThresholdReasonItemReasonsList\"}")]
        public virtual stripe.Invoice.InvoiceThresholdReasonItemReasonsList ItemReasons
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceThresholdReasonItemReasonsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceThresholdReason\"}", isOptional: true)]
        public virtual stripe.Invoice.IInvoiceThresholdReason? InternalValue
        {
            get => GetInstanceProperty<stripe.Invoice.IInvoiceThresholdReason?>();
            set => SetInstanceProperty(value);
        }
    }
}
