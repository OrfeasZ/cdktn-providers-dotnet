using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalReader
{
    [JsiiClass(nativeType: typeof(stripe.TerminalReader.TerminalReaderActionCollectInputsInputsSelectionOutputReference), fullyQualifiedName: "stripe.terminalReader.TerminalReaderActionCollectInputsInputsSelectionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TerminalReaderActionCollectInputsInputsSelectionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TerminalReaderActionCollectInputsInputsSelectionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TerminalReaderActionCollectInputsInputsSelectionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TerminalReaderActionCollectInputsInputsSelectionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "choices", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionCollectInputsInputsSelectionChoicesList\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionCollectInputsInputsSelectionChoicesList Choices
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionCollectInputsInputsSelectionChoicesList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Text
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionCollectInputsInputsSelection\"}", isOptional: true)]
        public virtual stripe.TerminalReader.ITerminalReaderActionCollectInputsInputsSelection? InternalValue
        {
            get => GetInstanceProperty<stripe.TerminalReader.ITerminalReaderActionCollectInputsInputsSelection?>();
            set => SetInstanceProperty(value);
        }
    }
}
