using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgent
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomization), fullyQualifiedName: "oci.generativeAiAgentAgent.GenerativeAiAgentAgentLlmConfigRoutingLlmCustomization")]
    public interface IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_agent_agent#instruction GenerativeAiAgentAgent#instruction}.</summary>
        [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Instruction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_agent_agent#llm_hyper_parameters GenerativeAiAgentAgent#llm_hyper_parameters}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_agent_agent#llm_selection GenerativeAiAgentAgent#llm_selection}
        /// </remarks>
        [JsiiProperty(name: "llmSelection", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgent.GenerativeAiAgentAgentLlmConfigRoutingLlmCustomizationLlmSelection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiAgentAgent.IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomizationLlmSelection? LlmSelection
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomization), fullyQualifiedName: "oci.generativeAiAgentAgent.GenerativeAiAgentAgentLlmConfigRoutingLlmCustomization")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiAgentAgent.IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomization
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_agent_agent#instruction GenerativeAiAgentAgent#instruction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Instruction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_agent_agent#llm_hyper_parameters GenerativeAiAgentAgent#llm_hyper_parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "llmHyperParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? LlmHyperParameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>llm_selection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_agent_agent#llm_selection GenerativeAiAgentAgent#llm_selection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "llmSelection", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgent.GenerativeAiAgentAgentLlmConfigRoutingLlmCustomizationLlmSelection\"}", isOptional: true)]
            public oci.GenerativeAiAgentAgent.IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomizationLlmSelection? LlmSelection
            {
                get => GetInstanceProperty<oci.GenerativeAiAgentAgent.IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomizationLlmSelection?>();
            }
        }
    }
}
