using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.InvoiceItem
{
    [JsiiClass(nativeType: typeof(stripe.InvoiceItem.InvoiceItemProrationDetailsCreditedItemsOutputReference), fullyQualifiedName: "stripe.invoiceItem.InvoiceItemProrationDetailsCreditedItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InvoiceItemProrationDetailsCreditedItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public InvoiceItemProrationDetailsCreditedItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected InvoiceItemProrationDetailsCreditedItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InvoiceItemProrationDetailsCreditedItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "invoiceItem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvoiceItem
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invoiceLineItemDetails", typeJson: "{\"fqn\":\"stripe.invoiceItem.InvoiceItemProrationDetailsCreditedItemsInvoiceLineItemDetailsOutputReference\"}")]
        public virtual stripe.InvoiceItem.InvoiceItemProrationDetailsCreditedItemsInvoiceLineItemDetailsOutputReference InvoiceLineItemDetails
        {
            get => GetInstanceProperty<stripe.InvoiceItem.InvoiceItemProrationDetailsCreditedItemsInvoiceLineItemDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.invoiceItem.InvoiceItemProrationDetailsCreditedItems\"}", isOptional: true)]
        public virtual stripe.InvoiceItem.IInvoiceItemProrationDetailsCreditedItems? InternalValue
        {
            get => GetInstanceProperty<stripe.InvoiceItem.IInvoiceItemProrationDetailsCreditedItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
