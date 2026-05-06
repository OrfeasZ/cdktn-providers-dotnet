using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgentEndpoint
{
    [JsiiByValue(fqn: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointGuardrailConfigPromptInjectionConfig")]
    public class GenerativeAiAgentAgentEndpointGuardrailConfigPromptInjectionConfig : oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointGuardrailConfigPromptInjectionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_agent_endpoint#input_guardrail_mode GenerativeAiAgentAgentEndpoint#input_guardrail_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputGuardrailMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InputGuardrailMode
        {
            get;
            set;
        }
    }
}
