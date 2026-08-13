using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.InvoiceItem
{
    [JsiiClass(nativeType: typeof(stripe.InvoiceItem.InvoiceItemProrationDetailsCreditedItemsInvoiceLineItemDetailsOutputReference), fullyQualifiedName: "stripe.invoiceItem.InvoiceItemProrationDetailsCreditedItemsInvoiceLineItemDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InvoiceItemProrationDetailsCreditedItemsInvoiceLineItemDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public InvoiceItemProrationDetailsCreditedItemsInvoiceLineItemDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected InvoiceItemProrationDetailsCreditedItemsInvoiceLineItemDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InvoiceItemProrationDetailsCreditedItemsInvoiceLineItemDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "invoice", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Invoice
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invoiceLineItems", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] InvoiceLineItems
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.invoiceItem.InvoiceItemProrationDetailsCreditedItemsInvoiceLineItemDetails\"}", isOptional: true)]
        public virtual stripe.InvoiceItem.IInvoiceItemProrationDetailsCreditedItemsInvoiceLineItemDetails? InternalValue
        {
            get => GetInstanceProperty<stripe.InvoiceItem.IInvoiceItemProrationDetailsCreditedItemsInvoiceLineItemDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
