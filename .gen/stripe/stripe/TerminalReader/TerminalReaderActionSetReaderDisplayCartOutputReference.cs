using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalReader
{
    [JsiiClass(nativeType: typeof(stripe.TerminalReader.TerminalReaderActionSetReaderDisplayCartOutputReference), fullyQualifiedName: "stripe.terminalReader.TerminalReaderActionSetReaderDisplayCartOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TerminalReaderActionSetReaderDisplayCartOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TerminalReaderActionSetReaderDisplayCartOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TerminalReaderActionSetReaderDisplayCartOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TerminalReaderActionSetReaderDisplayCartOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Currency
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lineItems", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionSetReaderDisplayCartLineItemsList\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionSetReaderDisplayCartLineItemsList LineItems
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionSetReaderDisplayCartLineItemsList>()!;
        }

        [JsiiProperty(name: "tax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tax
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "total", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Total
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionSetReaderDisplayCart\"}", isOptional: true)]
        public virtual stripe.TerminalReader.ITerminalReaderActionSetReaderDisplayCart? InternalValue
        {
            get => GetInstanceProperty<stripe.TerminalReader.ITerminalReaderActionSetReaderDisplayCart?>();
            set => SetInstanceProperty(value);
        }
    }
}
