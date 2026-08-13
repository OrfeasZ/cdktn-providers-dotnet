using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalReader
{
    [JsiiClass(nativeType: typeof(stripe.TerminalReader.TerminalReaderActionOutputReference), fullyQualifiedName: "stripe.terminalReader.TerminalReaderActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TerminalReaderActionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TerminalReaderActionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TerminalReaderActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TerminalReaderActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "apiError", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionApiErrorOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionApiErrorOutputReference ApiError
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionApiErrorOutputReference>()!;
        }

        [JsiiProperty(name: "collectInputs", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionCollectInputsOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionCollectInputsOutputReference CollectInputs
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionCollectInputsOutputReference>()!;
        }

        [JsiiProperty(name: "collectPaymentMethod", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionCollectPaymentMethodOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionCollectPaymentMethodOutputReference CollectPaymentMethod
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionCollectPaymentMethodOutputReference>()!;
        }

        [JsiiProperty(name: "confirmPaymentIntent", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionConfirmPaymentIntentOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionConfirmPaymentIntentOutputReference ConfirmPaymentIntent
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionConfirmPaymentIntentOutputReference>()!;
        }

        [JsiiProperty(name: "failureCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FailureCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "failureMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FailureMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "printContent", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionPrintContentOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionPrintContentOutputReference PrintContent
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionPrintContentOutputReference>()!;
        }

        [JsiiProperty(name: "processPaymentIntent", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionProcessPaymentIntentOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionProcessPaymentIntentOutputReference ProcessPaymentIntent
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionProcessPaymentIntentOutputReference>()!;
        }

        [JsiiProperty(name: "processSetupIntent", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionProcessSetupIntentOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionProcessSetupIntentOutputReference ProcessSetupIntent
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionProcessSetupIntentOutputReference>()!;
        }

        [JsiiProperty(name: "refundPayment", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionRefundPaymentOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionRefundPaymentOutputReference RefundPayment
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionRefundPaymentOutputReference>()!;
        }

        [JsiiProperty(name: "setReaderDisplay", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionSetReaderDisplayOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionSetReaderDisplayOutputReference SetReaderDisplay
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionSetReaderDisplayOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderAction\"}", isOptional: true)]
        public virtual stripe.TerminalReader.ITerminalReaderAction? InternalValue
        {
            get => GetInstanceProperty<stripe.TerminalReader.ITerminalReaderAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
