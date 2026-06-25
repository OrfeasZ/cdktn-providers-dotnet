using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentTool
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiAgentTool.GenerativeAiAgentToolToolConfigRerankingLlmCustomizationLlmSelectionOutputReference), fullyQualifiedName: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigRerankingLlmCustomizationLlmSelectionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiAgentToolToolConfigRerankingLlmCustomizationLlmSelectionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiAgentToolToolConfigRerankingLlmCustomizationLlmSelectionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GenerativeAiAgentToolToolConfigRerankingLlmCustomizationLlmSelectionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiAgentToolToolConfigRerankingLlmCustomizationLlmSelectionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEndpointId")]
        public virtual void ResetEndpointId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelId")]
        public virtual void ResetModelId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "llmSelectionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LlmSelectionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "llmSelectionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LlmSelectionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigRerankingLlmCustomizationLlmSelection\"}", isOptional: true)]
        public virtual oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigRerankingLlmCustomizationLlmSelection? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigRerankingLlmCustomizationLlmSelection?>();
            set => SetInstanceProperty(value);
        }
    }
}
