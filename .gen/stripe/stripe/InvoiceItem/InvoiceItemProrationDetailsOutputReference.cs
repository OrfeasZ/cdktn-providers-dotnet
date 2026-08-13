using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.InvoiceItem
{
    [JsiiClass(nativeType: typeof(stripe.InvoiceItem.InvoiceItemProrationDetailsOutputReference), fullyQualifiedName: "stripe.invoiceItem.InvoiceItemProrationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InvoiceItemProrationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public InvoiceItemProrationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected InvoiceItemProrationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InvoiceItemProrationDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "creditedItems", typeJson: "{\"fqn\":\"stripe.invoiceItem.InvoiceItemProrationDetailsCreditedItemsOutputReference\"}")]
        public virtual stripe.InvoiceItem.InvoiceItemProrationDetailsCreditedItemsOutputReference CreditedItems
        {
            get => GetInstanceProperty<stripe.InvoiceItem.InvoiceItemProrationDetailsCreditedItemsOutputReference>()!;
        }

        [JsiiProperty(name: "discountAmounts", typeJson: "{\"fqn\":\"stripe.invoiceItem.InvoiceItemProrationDetailsDiscountAmountsList\"}")]
        public virtual stripe.InvoiceItem.InvoiceItemProrationDetailsDiscountAmountsList DiscountAmounts
        {
            get => GetInstanceProperty<stripe.InvoiceItem.InvoiceItemProrationDetailsDiscountAmountsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.invoiceItem.InvoiceItemProrationDetails\"}", isOptional: true)]
        public virtual stripe.InvoiceItem.IInvoiceItemProrationDetails? InternalValue
        {
            get => GetInstanceProperty<stripe.InvoiceItem.IInvoiceItemProrationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
