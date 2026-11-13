using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiClass(nativeType: typeof(stripe.Invoice.InvoiceStatusDetailsOutputReference), fullyQualifiedName: "stripe.invoice.InvoiceStatusDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InvoiceStatusDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public InvoiceStatusDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected InvoiceStatusDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InvoiceStatusDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "uncollectible", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceStatusDetailsUncollectibleOutputReference\"}")]
        public virtual stripe.Invoice.InvoiceStatusDetailsUncollectibleOutputReference Uncollectible
        {
            get => GetInstanceProperty<stripe.Invoice.InvoiceStatusDetailsUncollectibleOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceStatusDetails\"}", isOptional: true)]
        public virtual stripe.Invoice.IInvoiceStatusDetails? InternalValue
        {
            get => GetInstanceProperty<stripe.Invoice.IInvoiceStatusDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
