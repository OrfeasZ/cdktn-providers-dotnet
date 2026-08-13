using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalReader
{
    [JsiiClass(nativeType: typeof(stripe.TerminalReader.TerminalReaderActionCollectPaymentMethodCollectConfigOutputReference), fullyQualifiedName: "stripe.terminalReader.TerminalReaderActionCollectPaymentMethodCollectConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TerminalReaderActionCollectPaymentMethodCollectConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TerminalReaderActionCollectPaymentMethodCollectConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TerminalReaderActionCollectPaymentMethodCollectConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TerminalReaderActionCollectPaymentMethodCollectConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "enableCustomerCancellation", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableCustomerCancellation
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "skipTipping", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SkipTipping
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "tipping", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionCollectPaymentMethodCollectConfigTippingOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionCollectPaymentMethodCollectConfigTippingOutputReference Tipping
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionCollectPaymentMethodCollectConfigTippingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionCollectPaymentMethodCollectConfig\"}", isOptional: true)]
        public virtual stripe.TerminalReader.ITerminalReaderActionCollectPaymentMethodCollectConfig? InternalValue
        {
            get => GetInstanceProperty<stripe.TerminalReader.ITerminalReaderActionCollectPaymentMethodCollectConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
