using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentTool
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigEmbeddingLlmCustomizationOutputReference), fullyQualifiedName: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigEmbeddingLlmCustomizationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiAgentToolToolConfigEmbeddingLlmCustomizationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiAgentToolToolConfigEmbeddingLlmCustomizationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GenerativeAiAgentToolToolConfigEmbeddingLlmCustomizationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiAgentToolToolConfigEmbeddingLlmCustomizationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLlmSelection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigEmbeddingLlmCustomizationLlmSelection\"}}]")]
        public virtual void PutLlmSelection(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigEmbeddingLlmCustomizationLlmSelection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigEmbeddingLlmCustomizationLlmSelection)}, new object[]{@value});
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

        [JsiiProperty(name: "llmSelection", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigEmbeddingLlmCustomizationLlmSelectionOutputReference\"}")]
        public virtual oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigEmbeddingLlmCustomizationLlmSelectionOutputReference LlmSelection
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigEmbeddingLlmCustomizationLlmSelectionOutputReference>()!;
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
        [JsiiProperty(name: "llmSelectionInput", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigEmbeddingLlmCustomizationLlmSelection\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigEmbeddingLlmCustomizationLlmSelection? LlmSelectionInput
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigEmbeddingLlmCustomizationLlmSelection?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigEmbeddingLlmCustomization\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigEmbeddingLlmCustomization? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigEmbeddingLlmCustomization?>();
            set => SetInstanceProperty(value);
        }
    }
}
