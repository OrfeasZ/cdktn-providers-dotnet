using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalReader
{
    [JsiiClass(nativeType: typeof(stripe.TerminalReader.TerminalReaderActionCollectPaymentMethodOutputReference), fullyQualifiedName: "stripe.terminalReader.TerminalReaderActionCollectPaymentMethodOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TerminalReaderActionCollectPaymentMethodOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TerminalReaderActionCollectPaymentMethodOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TerminalReaderActionCollectPaymentMethodOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TerminalReaderActionCollectPaymentMethodOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "collectConfig", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionCollectPaymentMethodCollectConfigOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionCollectPaymentMethodCollectConfigOutputReference CollectConfig
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionCollectPaymentMethodCollectConfigOutputReference>()!;
        }

        [JsiiProperty(name: "paymentIntent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentIntent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionCollectPaymentMethod\"}", isOptional: true)]
        public virtual stripe.TerminalReader.ITerminalReaderActionCollectPaymentMethod? InternalValue
        {
            get => GetInstanceProperty<stripe.TerminalReader.ITerminalReaderActionCollectPaymentMethod?>();
            set => SetInstanceProperty(value);
        }
    }
}
