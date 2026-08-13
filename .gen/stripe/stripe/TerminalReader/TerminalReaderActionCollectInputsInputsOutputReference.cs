using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalReader
{
    [JsiiClass(nativeType: typeof(stripe.TerminalReader.TerminalReaderActionCollectInputsInputsOutputReference), fullyQualifiedName: "stripe.terminalReader.TerminalReaderActionCollectInputsInputsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class TerminalReaderActionCollectInputsInputsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public TerminalReaderActionCollectInputsInputsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TerminalReaderActionCollectInputsInputsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TerminalReaderActionCollectInputsInputsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "customText", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionCollectInputsInputsCustomTextOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionCollectInputsInputsCustomTextOutputReference CustomText
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionCollectInputsInputsCustomTextOutputReference>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionCollectInputsInputsEmailOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionCollectInputsInputsEmailOutputReference Email
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionCollectInputsInputsEmailOutputReference>()!;
        }

        [JsiiProperty(name: "numeric", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionCollectInputsInputsNumericOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionCollectInputsInputsNumericOutputReference Numeric
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionCollectInputsInputsNumericOutputReference>()!;
        }

        [JsiiProperty(name: "phone", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionCollectInputsInputsPhoneOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionCollectInputsInputsPhoneOutputReference Phone
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionCollectInputsInputsPhoneOutputReference>()!;
        }

        [JsiiProperty(name: "required", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Required
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "selection", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionCollectInputsInputsSelectionOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionCollectInputsInputsSelectionOutputReference Selection
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionCollectInputsInputsSelectionOutputReference>()!;
        }

        [JsiiProperty(name: "signature", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionCollectInputsInputsSignatureOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionCollectInputsInputsSignatureOutputReference Signature
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionCollectInputsInputsSignatureOutputReference>()!;
        }

        [JsiiProperty(name: "skipped", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Skipped
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "text", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionCollectInputsInputsTextOutputReference\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionCollectInputsInputsTextOutputReference Text
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionCollectInputsInputsTextOutputReference>()!;
        }

        [JsiiProperty(name: "toggles", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionCollectInputsInputsTogglesList\"}")]
        public virtual stripe.TerminalReader.TerminalReaderActionCollectInputsInputsTogglesList Toggles
        {
            get => GetInstanceProperty<stripe.TerminalReader.TerminalReaderActionCollectInputsInputsTogglesList>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.terminalReader.TerminalReaderActionCollectInputsInputs\"}", isOptional: true)]
        public virtual stripe.TerminalReader.ITerminalReaderActionCollectInputsInputs? InternalValue
        {
            get => GetInstanceProperty<stripe.TerminalReader.ITerminalReaderActionCollectInputsInputs?>();
            set => SetInstanceProperty(value);
        }
    }
}
