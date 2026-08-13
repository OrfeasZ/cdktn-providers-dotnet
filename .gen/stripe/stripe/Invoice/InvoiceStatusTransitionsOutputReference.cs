using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiClass(nativeType: typeof(stripe.Invoice.InvoiceStatusTransitionsOutputReference), fullyQualifiedName: "stripe.invoice.InvoiceStatusTransitionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InvoiceStatusTransitionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public InvoiceStatusTransitionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected InvoiceStatusTransitionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InvoiceStatusTransitionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "finalizedAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FinalizedAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "markedUncollectibleAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MarkedUncollectibleAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "paidAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PaidAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "voidedAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VoidedAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceStatusTransitions\"}", isOptional: true)]
        public virtual stripe.Invoice.IInvoiceStatusTransitions? InternalValue
        {
            get => GetInstanceProperty<stripe.Invoice.IInvoiceStatusTransitions?>();
            set => SetInstanceProperty(value);
        }
    }
}
