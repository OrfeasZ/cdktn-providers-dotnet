using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalReader
{
    [JsiiClass(nativeType: typeof(stripe.TerminalReader.TerminalReaderActionProcessPaymentIntentProcessConfigOutputReference), fullyQualifiedName: "stripe.terminalReader.TerminalReaderActionProcessPaymentIntentProcessConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TerminalReaderActionProcessPaymentIntentProcessConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TerminalReaderActionProcessPaymentIntentProcessConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TerminalReaderActionProcessPaymentIntentProcessConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TerminalReaderActionProcessPaymentIntentProcessConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "enableCustomerCancellation", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableCustomerCancellation
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "returnUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReturnUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "skipTipping", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SkipTipping
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "tipping", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionProcessPaymentIntentProcessConfigTippingOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionProcessPaymentIntentProcessConfigTippingOutputReference Tipping
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionProcessPaymentIntentProcessConfigTippingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionProcessPaymentIntentProcessConfig\"}", isOptional: true)]
        public virtual stripe.TerminalReader.ITerminalReaderActionProcessPaymentIntentProcessConfig? InternalValue
        {
            get => GetInstanceProperty<stripe.TerminalReader.ITerminalReaderActionProcessPaymentIntentProcessConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
