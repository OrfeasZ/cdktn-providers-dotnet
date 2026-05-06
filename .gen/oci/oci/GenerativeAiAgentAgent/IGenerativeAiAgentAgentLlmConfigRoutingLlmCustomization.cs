using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgent
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomization), fullyQualifiedName: "oci.generativeAiAgentAgent.GenerativeAiAgentAgentLlmConfigRoutingLlmCustomization")]
    public interface IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_agent#instruction GenerativeAiAgentAgent#instruction}.</summary>
        [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Instruction
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_agent#instruction GenerativeAiAgentAgent#instruction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Instruction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
