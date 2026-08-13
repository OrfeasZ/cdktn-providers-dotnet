using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalReader
{
    [JsiiClass(nativeType: typeof(stripe.TerminalReader.TerminalReaderActionRefundPaymentOutputReference), fullyQualifiedName: "stripe.terminalReader.TerminalReaderActionRefundPaymentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TerminalReaderActionRefundPaymentOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TerminalReaderActionRefundPaymentOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TerminalReaderActionRefundPaymentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TerminalReaderActionRefundPaymentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Amount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "charge", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Charge
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Metadata
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "paymentIntent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentIntent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Reason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refund", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Refund
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refundApplicationFee", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RefundApplicationFee
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "refundPaymentConfig", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionRefundPaymentRefundPaymentConfigOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionRefundPaymentRefundPaymentConfigOutputReference RefundPaymentConfig
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionRefundPaymentRefundPaymentConfigOutputReference>()!;
        }

        [JsiiProperty(name: "reverseTransfer", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ReverseTransfer
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionRefundPayment\"}", isOptional: true)]
        public virtual stripe.TerminalReader.ITerminalReaderActionRefundPayment? InternalValue
        {
            get => GetInstanceProperty<stripe.TerminalReader.ITerminalReaderActionRefundPayment?>();
            set => SetInstanceProperty(value);
        }
    }
}
