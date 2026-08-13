using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiClass(nativeType: typeof(stripe.Invoice.InvoiceParentOutputReference), fullyQualifiedName: "stripe.invoice.InvoiceParentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InvoiceParentOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public InvoiceParentOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected InvoiceParentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InvoiceParentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "quoteDetails", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceParentQuoteDetailsOutputReference\"}")]
        public virtual stripe.Invoice.InvoiceParentQuoteDetailsOutputReference QuoteDetails
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceParentQuoteDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "subscriptionDetails", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceParentSubscriptionDetailsOutputReference\"}")]
        public virtual stripe.Invoice.InvoiceParentSubscriptionDetailsOutputReference SubscriptionDetails
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceParentSubscriptionDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceParent\"}", isOptional: true)]
        public virtual stripe.Invoice.IInvoiceParent? InternalValue
        {
            get => GetInstanceProperty<stripe.Invoice.IInvoiceParent?>();
            set => SetInstanceProperty(value);
        }
    }
}
