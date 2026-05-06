using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgent
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentAgentLlmConfig), fullyQualifiedName: "oci.generativeAiAgentAgent.GenerativeAiAgentAgentLlmConfig")]
    public interface IGenerativeAiAgentAgentLlmConfig
    {
        /// <summary>routing_llm_customization block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_agent#routing_llm_customization GenerativeAiAgentAgent#routing_llm_customization}
        /// </remarks>
        [JsiiProperty(name: "routingLlmCustomization", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgent.GenerativeAiAgentAgentLlmConfigRoutingLlmCustomization\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiAgentAgent.IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomization? RoutingLlmCustomization
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiAgentAgentLlmConfig), fullyQualifiedName: "oci.generativeAiAgentAgent.GenerativeAiAgentAgentLlmConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiAgentAgent.IGenerativeAiAgentAgentLlmConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>routing_llm_customization block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_agent#routing_llm_customization GenerativeAiAgentAgent#routing_llm_customization}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routingLlmCustomization", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgent.GenerativeAiAgentAgentLlmConfigRoutingLlmCustomization\"}", isOptional: true)]
            public oci.GenerativeAiAgentAgent.IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomization? RoutingLlmCustomization
            {
                get => GetInstanceProperty<oci.GenerativeAiAgentAgent.IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomization?>();
            }
        }
    }
}
