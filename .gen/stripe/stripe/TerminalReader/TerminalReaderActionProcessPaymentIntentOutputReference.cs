using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalReader
{
    [JsiiClass(nativeType: typeof(stripe.TerminalReader.TerminalReaderActionProcessPaymentIntentOutputReference), fullyQualifiedName: "stripe.terminalReader.TerminalReaderActionProcessPaymentIntentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TerminalReaderActionProcessPaymentIntentOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TerminalReaderActionProcessPaymentIntentOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TerminalReaderActionProcessPaymentIntentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TerminalReaderActionProcessPaymentIntentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "paymentIntent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentIntent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "processConfig", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionProcessPaymentIntentProcessConfigOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionProcessPaymentIntentProcessConfigOutputReference ProcessConfig
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionProcessPaymentIntentProcessConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionProcessPaymentIntent\"}", isOptional: true)]
        public virtual stripe.TerminalReader.ITerminalReaderActionProcessPaymentIntent? InternalValue
        {
            get => GetInstanceProperty<stripe.TerminalReader.ITerminalReaderActionProcessPaymentIntent?>();
            set => SetInstanceProperty(value);
        }
    }
}
