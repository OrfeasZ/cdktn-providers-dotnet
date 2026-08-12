using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgentEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs")]
    public class GenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs : oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointProvisionedCapacityConfigToolRuntimeConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_agent_agent_endpoint#tool_runtime_config_type GenerativeAiAgentAgentEndpoint#tool_runtime_config_type}.</summary>
        [JsiiProperty(name: "toolRuntimeConfigType", typeJson: "{\"primitive\":\"string\"}")]
        public string ToolRuntimeConfigType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/generative_ai_agent_agent_endpoint#version GenerativeAiAgentAgentEndpoint#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
