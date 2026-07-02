using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentTool
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentToolToolConfigReasoningLlmCustomization), fullyQualifiedName: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigReasoningLlmCustomization")]
    public interface IGenerativeAiAgentToolToolConfigReasoningLlmCustomization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/generative_ai_agent_tool#instruction GenerativeAiAgentTool#instruction}.</summary>
        [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Instruction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/generative_ai_agent_tool#llm_hyper_parameters GenerativeAiAgentTool#llm_hyper_parameters}.</summary>
        [JsiiProperty(name: "llmHyperParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? LlmHyperParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>llm_selection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/generative_ai_agent_tool#llm_selection GenerativeAiAgentTool#llm_selection}
        /// </remarks>
        [JsiiProperty(name: "llmSelection", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigReasoningLlmCustomizationLlmSelection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigReasoningLlmCustomizationLlmSelection? LlmSelection
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiAgentToolToolConfigReasoningLlmCustomization), fullyQualifiedName: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigReasoningLlmCustomization")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigReasoningLlmCustomization
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/generative_ai_agent_tool#instruction GenerativeAiAgentTool#instruction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Instruction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/generative_ai_agent_tool#llm_hyper_parameters GenerativeAiAgentTool#llm_hyper_parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "llmHyperParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? LlmHyperParameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>llm_selection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/generative_ai_agent_tool#llm_selection GenerativeAiAgentTool#llm_selection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "llmSelection", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigReasoningLlmCustomizationLlmSelection\"}", isOptional: true)]
            public oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigReasoningLlmCustomizationLlmSelection? LlmSelection
            {
                get => GetInstanceProperty<oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigReasoningLlmCustomizationLlmSelection?>();
            }
        }
    }
}
