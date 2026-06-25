using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentTool
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigReasoningLlmCustomizationOutputReference), fullyQualifiedName: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigReasoningLlmCustomizationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiAgentToolToolConfigReasoningLlmCustomizationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiAgentToolToolConfigReasoningLlmCustomizationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GenerativeAiAgentToolToolConfigReasoningLlmCustomizationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiAgentToolToolConfigReasoningLlmCustomizationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLlmSelection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigReasoningLlmCustomizationLlmSelection\"}}]")]
        public virtual void PutLlmSelection(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigReasoningLlmCustomizationLlmSelection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigReasoningLlmCustomizationLlmSelection)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInstruction")]
        public virtual void ResetInstruction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLlmHyperParameters")]
        public virtual void ResetLlmHyperParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLlmSelection")]
        public virtual void ResetLlmSelection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "llmSelection", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigReasoningLlmCustomizationLlmSelectionOutputReference\"}")]
        public virtual oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigReasoningLlmCustomizationLlmSelectionOutputReference LlmSelection
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigReasoningLlmCustomizationLlmSelectionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instructionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstructionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "llmHyperParametersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? LlmHyperParametersInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "llmSelectionInput", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigReasoningLlmCustomizationLlmSelection\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigReasoningLlmCustomizationLlmSelection? LlmSelectionInput
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigReasoningLlmCustomizationLlmSelection?>();
        }

        [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Instruction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "llmHyperParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> LlmHyperParameters
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigReasoningLlmCustomization\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigReasoningLlmCustomization? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigReasoningLlmCustomization?>();
            set => SetInstanceProperty(value);
        }
    }
}
