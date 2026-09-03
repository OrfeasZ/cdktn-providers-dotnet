using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgent
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomizationLlmSelection), fullyQualifiedName: "oci.generativeAiAgentAgent.GenerativeAiAgentAgentLlmConfigRoutingLlmCustomizationLlmSelection")]
    public interface IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomizationLlmSelection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_agent_agent#llm_selection_type GenerativeAiAgentAgent#llm_selection_type}.</summary>
        [JsiiProperty(name: "llmSelectionType", typeJson: "{\"primitive\":\"string\"}")]
        string LlmSelectionType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_agent_agent#endpoint_id GenerativeAiAgentAgent#endpoint_id}.</summary>
        [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndpointId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_agent_agent#model_id GenerativeAiAgentAgent#model_id}.</summary>
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ModelId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomizationLlmSelection), fullyQualifiedName: "oci.generativeAiAgentAgent.GenerativeAiAgentAgentLlmConfigRoutingLlmCustomizationLlmSelection")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiAgentAgent.IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomizationLlmSelection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_agent_agent#llm_selection_type GenerativeAiAgentAgent#llm_selection_type}.</summary>
            [JsiiProperty(name: "llmSelectionType", typeJson: "{\"primitive\":\"string\"}")]
            public string LlmSelectionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_agent_agent#endpoint_id GenerativeAiAgentAgent#endpoint_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndpointId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_agent_agent#model_id GenerativeAiAgentAgent#model_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ModelId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
